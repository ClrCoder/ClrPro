// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>
    ///     The runtime environment for the application. This abstractions allocates some room between application and CLR
    ///     Runtime. Making possible to define some execution policies and CLR Runtime behavior overrides.
    /// </summary>
    /// <remarks>
    ///     <para>Intended to be injectable.</para>
    ///     <para>The OS Process environment is not included in the API of this abstraction.</para>
    ///     <para></para>
    /// </remarks>
    [PublicAPI]
    public interface IRuntimeEnvironment
    {
        private static IRuntimeEnvironment _default = new SystemRuntimeEnvironment();

        /// <summary>
        ///     The default runtime environment for the DI-less usage. Initially it equals to
        ///     <see cref="SystemRuntimeEnvironment" />.
        /// </summary>
        static IRuntimeEnvironment Default
        {
            get => _default;
            set => _default = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///     Tests exceptions is not critical for the execution flow and can be muted or redirected.
        /// </summary>
        /// <remarks>
        ///     The default implementation treating as non-mutable the next exceptions
        ///     <see cref="AppDomainUnloadedException" />, <see cref="ThreadAbortException" />, <see cref="OutOfMemoryException" />
        ///     .
        /// </remarks>
        /// <param name="exception">The unhandledException to test.</param>
        /// <returns>true, if the unhandledException could be muted or redirected, otherwise false.</returns>
        bool IsRedirectableException(Exception exception)
        {
            switch (exception)
            {
                case OutOfMemoryException _:
                    return false;
                case ThreadAbortException _:
                    return false;
                case AppDomainUnloadedException _:
                    return false;
                case UnhandledException _:
                    return false;
            }

            return true;
        }

        /// <summary>
        ///     Terminates runtime fast, but performs some important actions.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         For example application during execution may schedule some "Critical" tasks to dedicated "Critical"
        ///         <see cref="TaskScheduler" /> that should be completed before the call to
        ///         <see cref="Environment.FailFast(string)" />. Or some "last chance" crash log could be written.
        ///     </para>
        ///     <para>Default implementation of this method calls <see cref="Environment.FailFast(string, Exception)" />.</para>
        /// </remarks>
        /// <param name="message">The terminate reason message.</param>
        /// <param name="exception">The cause unhandledException.</param>
        void TerminateRuntime(string message, Exception? exception)
        {
            Environment.FailFast("Unable to recover after an unhandled unhandledException.", exception);
        }

        /// <summary>
        ///     Gives runtime a chance to process exception that was not handled by the application. Method could be called from a
        ///     finalizer.
        /// </summary>
        /// <param name="unhandledException">The unhandled exception.</param>
        /// <remarks>
        ///     <para>
        ///         Default implementation of this method calls <see cref="TryRecoverOnUnhandledException" /> then depending on
        ///         result
        ///         calls <see cref="TerminateRuntime" /> or <see cref="ProcessMutedException" />.
        ///     </para>
        ///     <para>
        ///         This method should be called in a place where unhandled exception was detected.
        ///     </para>
        /// </remarks>
        void ProcessUnhandledException([NotNull] Exception unhandledException)
        {
            if (unhandledException == null)
            {
                throw new ArgumentNullException(nameof(unhandledException));
            }

            if (!TryRecoverOnUnhandledException(unhandledException))
            {
                try
                {
                    TerminateRuntime(
                        "Unable to recover runtime after the unhandled exception.",
                        unhandledException);
                }
#pragma warning disable CA1031 // Do not catch general exception types
                catch (Exception ex)
#pragma warning restore CA1031 // Do not catch general exception types
                {
                    Environment.FailFast("Runtime termination error.", ex);
                }
            }
        }

        /// <summary>
        ///     Processes muted exception. Method could be called from a finalizer.
        /// </summary>
        /// <param name="mutedException">The muted exception.</param>
        /// <remarks>By default this method writing message to the <see cref="Trace.TraceError(string)" /> output.</remarks>
        void ProcessMutedException(Exception mutedException)
        {
            Trace.TraceError($"Caught muted exception: {mutedException}");
        }

        /// <summary>
        ///     Tries to recover runtime in a case of unhandled exception.
        /// </summary>
        /// <param name="exception">The unhandled exception.</param>
        /// <remarks> Default implementation ignores <see cref="OperationCanceledException" />.</remarks>
        /// <returns><see langword="true" /> if the passed exception was handled, <see langword="false" /> otherwise.</returns>
        protected virtual bool TryRecoverOnUnhandledException(Exception exception)
        {
            var canRecover = false;
            switch (exception)
            {
                case OperationCanceledException _:
                    canRecover = true;
                    break;
            }

            if (canRecover)
            {
                Trace.TraceError($"Recovered from exception: {exception}");
            }

            return canRecover;
        }
    }
}
