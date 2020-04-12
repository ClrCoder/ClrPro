// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Tasks
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.ExceptionServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     Asynchronous operation (task-like) completion result.
    /// </summary>
    /// <remarks>
    ///     This structure does not contains result value, due to performance reasons.
    /// </remarks>
    [PublicAPI]
    [SuppressMessage(
        "Performance",
        "CA1815:Override equals and operator equals on value types",
        Justification = "Hope it would be useless to compare results.")]
    public readonly struct TaskCompletionResult
    {
        private TaskCompletionResult(TaskExceptionHolder? exceptionHolder)
        {
            ExceptionHolder = exceptionHolder;
        }

        /// <summary>
        ///     Gets the <see cref="ExceptionHolder" /> if the task wasn't completed successfully or <see langword="null" />
        ///     otherwise.
        /// </summary>
        public TaskExceptionHolder? ExceptionHolder { get; }

        /// <summary>
        ///     Gets whether the <see cref="ValueTask" /> represents a successfully completed operation result.
        /// </summary>
        public bool IsSuccessful => ExceptionHolder == null;

        /// <summary>
        ///     Gets whether the <see cref="ValueTask" /> represents a cancelled operation result.
        /// </summary>
        public bool IsCancelled => ExceptionHolder != null && ExceptionHolder.IsCancellation;

        /// <summary>
        ///     Gets whether the <see cref="ValueTask" /> represents a faulted operation result.
        /// </summary>
        public bool IsFaulted => ExceptionHolder != null && !ExceptionHolder.IsCancellation;

        /// <summary>
        ///     This method should be called in the stack where exception was handled. Prefer to use
        ///     <see cref="FromDispatchInfo" /> instead of this method.
        /// </summary>
        /// <remarks>
        ///     Use this method only at the same thread where exception was caught. The dispatch info will be captured inside this
        ///     method.
        /// </remarks>
        /// <param name="exception">The fault exception.</param>
        /// <returns>The task result.</returns>
        public static TaskCompletionResult CaptureFromException(Exception exception)
        {
            return new TaskCompletionResult(TaskExceptionHolder.CaptureFromException(exception));
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TaskCompletionResult" /> struct with the specified fault exception
        ///     dispatch info.
        /// </summary>
        /// <param name="dispatchInfo">The exception with the information for the further rethrow.</param>
        /// <returns>The <see cref="TaskCompletionResult" /> with fault.</returns>
        public static TaskCompletionResult FromDispatchInfo(ExceptionDispatchInfo dispatchInfo)
        {
            if (dispatchInfo == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dispatchInfo);
            }

            return new TaskCompletionResult(TaskExceptionHolder.FromDispatchInfo(dispatchInfo));
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="TaskCompletionResult" /> from the provided cancellation token.
        /// </summary>
        /// <param name="token">The cancellation token to wrap as the task result.</param>
        /// <returns>The task result with the cancelled state.</returns>
        /// <exception cref="InvalidOperationException">The cancellation token is not yet cancelled.</exception>
        public static TaskCompletionResult FromCancellation(CancellationToken token)
        {
            if (!token.IsCancellationRequested)
            {
                // We can avoid to use ThrowHelper here, because this method will not be inlined in any case.
                throw new ArgumentException("The token should be in the cancelled state.");
            }

            ExceptionDispatchInfo? di = null;
            try
            {
                token.ThrowIfCancellationRequested();
            }
            catch (OperationCanceledException ex)
            {
                di = ExceptionDispatchInfo.Capture(ex);
            }

            // ReSharper disable once AssignNullToNotNullAttribute
            return new TaskCompletionResult(TaskExceptionHolder.FromDispatchInfo(di!));
        }
    }
}
