// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Tasks
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     The wrapper around <see cref="TaskCompletionSource{TResult}" /> that provides
    ///     <see cref="ITaskCompletionSource" />
    ///     contract.
    /// </summary>
    /// <typeparam name="T">The type of the async operation result.</typeparam>
    [PublicAPI]
    [SuppressMessage(
        "Performance",
        "CA1815:Override equals and operator equals on value types",
        Justification = "Reviewed")]
    public struct TaskCompletionSourceWrapper<T> : ITaskCompletionSource<T>
    {
        private readonly TaskCompletionSource<T> _completionSource;

        /// <summary>
        ///     Initializes a new instance of the <see cref="TaskCompletionSourceWrapper{T}" /> struct.
        /// </summary>
        /// <param name="completionSource">The completion source to wrap.</param>
        public TaskCompletionSourceWrapper(TaskCompletionSource<T> completionSource)
        {
            _completionSource = completionSource;
        }

        /// <summary>
        ///     The implicit conversion operator.
        /// </summary>
        /// <param name="completionSource"><see cref="TaskCompletionSource{TResult}" /> to convert.</param>
        [SuppressMessage(
            "Usage",
            "CA2225:Operator overloads have named alternates",
            Justification = "Constructor can be used in languages that does not supports operators.")]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator TaskCompletionSourceWrapper<T>(TaskCompletionSource<T> completionSource)
        {
            return new TaskCompletionSourceWrapper<T>(completionSource);
        }

        /// <inheritdoc />
        public void SetCompletionResult(TaskCompletionResult completionResult, T result)
        {
            if (completionResult.IsSuccessful)
            {
                _completionSource.SetResult(result);
            }
            else
            {
                SetFaultCompletionSlow(completionResult);
            }
        }

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Reviewed")]
        private void SetFaultCompletionSlow(TaskCompletionResult completionResult)
        {
            try
            {
                // Rethrowing exception to restore it's captured state.
                completionResult.ExceptionHolder!.DispatchInfo.Throw();
            }
            catch (Exception ex)
            {
                _completionSource.SetException(ex);
            }
        }
    }
}
