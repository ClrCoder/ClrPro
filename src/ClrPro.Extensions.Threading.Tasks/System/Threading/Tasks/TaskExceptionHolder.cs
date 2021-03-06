// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Tasks
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using System.Runtime.ExceptionServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     The holder for the completion exception with the dispatch info.
    /// </summary>
    /// <remarks>
    ///     Additional allocation to hold non-successful result of asynchronous operation is acceptable, due to
    ///     <see cref="Exception" /> itself already very expensive.
    /// </remarks>
    [PublicAPI]
    public class TaskExceptionHolder
    {
        private TaskExceptionHolder(ExceptionDispatchInfo dispatchInfo, bool isCancellation)
        {
            if (dispatchInfo.SourceException is OperationCanceledException)
            {
                IsCancellation = true;
            }

            DispatchInfo = dispatchInfo;
            IsCancellation = isCancellation;
        }

        /// <summary>
        ///     Gets where the held exception is <see cref="OperationCanceledException" />.
        /// </summary>
        public bool IsCancellation { get; }

        /// <summary>
        ///     Gets the <see cref="Exception" /> from the holder.
        /// </summary>
        public Exception Exception => DispatchInfo.SourceException;

        /// <summary>
        ///     Gets the <see cref="ExceptionDispatchInfo" /> from the holder.
        /// </summary>
        public ExceptionDispatchInfo DispatchInfo { get; }

        /// <summary>
        ///     Creates a new instance of the <see cref="TaskExceptionHolder" /> from the dispatch info.
        /// </summary>
        /// <param name="dispatchInfo">The exception with the captured stacktrace.</param>
        /// <returns>The created instance.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SuppressMessage(
            "Design",
            "CA1062:Validate arguments of public methods",
            Justification = "The argument has been validated.")]
        public static TaskExceptionHolder FromDispatchInfo(
            ExceptionDispatchInfo dispatchInfo)
        {
            if (dispatchInfo == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.dispatchInfo);
            }

            return new TaskExceptionHolder(
                dispatchInfo,
                dispatchInfo.SourceException is OperationCanceledException);
        }

        /// <summary>
        ///     Creates a new instance of the <see cref="TaskExceptionHolder" /> from the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <returns>The created instance.</returns>
        public static TaskExceptionHolder CaptureFromException(Exception exception)
        {
            if (exception == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.exception);
            }

            return new TaskExceptionHolder(
                ExceptionDispatchInfo.Capture(exception),
                exception is OperationCanceledException);
        }
    }
}
