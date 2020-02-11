// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Tasks.Sources
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     Ready to use wrapper for the <see cref="ManualResetValueTaskSourceCore{TResult}" />.
    /// </summary>
    /// <typeparam name="T">The type of the asynchronous operation result.</typeparam>
    [PublicAPI]
    [SuppressMessage(
        "Design",
        "CA1033:Interface methods should be callable by child types",
        Justification = "Reviewed")]
    public sealed class CompletionSourceSlim<T> : IValueTaskSource, ITaskCompletionSource<T>
    {
        // ReSharper disable once RedundantDefaultMemberInitializer
        private ManualResetValueTaskSourceCore2<T> _core = default;

        /// <inheritdoc />
        void IValueTaskSource.GetResult(short token)
        {
            _core.GetResult(token);
        }

        /// <inheritdoc />
        ValueTaskSourceStatus IValueTaskSource.GetStatus(short token)
        {
            return _core.GetStatus(token);
        }

        /// <inheritdoc />
        void IValueTaskSource.OnCompleted(
            Action<object?> continuation,
            object state,
            short token,
            ValueTaskSourceOnCompletedFlags flags)
        {
            _core.OnCompleted(continuation, state, token, flags);
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetCompletionResult(TaskCompletionResult completionResult, T result)
        {
            if (completionResult.IsSuccessful)
            {
                _core.SetResult(result);
            }
            else
            {
                _core.SetExceptionDispatchInfo(completionResult.ExceptionHolder!.DispatchInfo);
            }
        }
    }
}
