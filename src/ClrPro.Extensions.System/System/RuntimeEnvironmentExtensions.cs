// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>
    ///     Extension method related to the <see cref="IRuntimeEnvironment" /> .
    /// </summary>
    [PublicAPI]
    public static class RuntimeEnvironmentExtensions
    {
        /// <summary>
        ///     Invokes specified asynchronous <c>action</c> with redirecting raised
        ///     exceptions to the unhandled or muted exception flow.
        /// </summary>
        /// <param name="task">The <c>task</c> to execute async.</param>
        /// <param name="runtimeEnvironment">The application runtime.</param>
        /// <param name="allowMute">
        ///     <see langword="true" /> to send exception to the
        ///     <see cref="IRuntimeEnvironment.ProcessMutedException" />, otherwise pass exception to the
        ///     <see cref="IRuntimeEnvironment.ProcessUnhandledException" />.
        /// </param>
        /// <param name="continueOnCapturedContext">
        ///     <see langword="true" /> to attempt to marshal the continuation back
        ///     to the captured context; otherwise, <see langword="false" /> .
        /// </param>
        /// <returns>
        ///     Async execution <c>task</c>.
        /// </returns>
        public static async ValueTask ConfigureNoThrow(
            this ValueTask task,
            IRuntimeEnvironment runtimeEnvironment,
            bool allowMute = false,
            bool continueOnCapturedContext = true)
        {
            if (runtimeEnvironment == null)
            {
                throw new ArgumentNullException(nameof(runtimeEnvironment));
            }

            try
            {
                if (!continueOnCapturedContext)
                {
                    await task.ConfigureAwait(false);
                }
                else
                {
                    await task;
                }
            }
            catch (Exception ex) when (runtimeEnvironment.IsRedirectableException(ex))
            {
                if (allowMute)
                {
                    runtimeEnvironment.ProcessMutedException(ex);
                }
                else
                {
                    runtimeEnvironment.ProcessUnhandledException(ex);
                }
            }
        }

        /// <summary>
        ///     Invokes specified asynchronous <c>action</c> with redirecting raised
        ///     exceptions to the unhandled or muted exception flow.
        /// </summary>
        /// <param name="task">The <c>task</c> to execute async.</param>
        /// <param name="runtimeEnvironment">The application runtime.</param>
        /// <param name="allowMute">
        ///     If the task was finished with errors: <see langword="true" /> allows to mute exception,
        ///     otherwise process it as unhandled.
        /// </param>
        /// <param name="continueOnCapturedContext">
        ///     <see langword="true" /> to attempt to marshal the continuation back
        ///     to the captured context; otherwise, <see langword="false" /> .
        /// </param>
        /// <returns>
        ///     Async execution <c>task</c>.
        /// </returns>
        public static async ValueTask ConfigureNoThrow(
            this Task task,
            [NotNull] IRuntimeEnvironment runtimeEnvironment,
            bool allowMute = false,
            bool continueOnCapturedContext = true)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            if (runtimeEnvironment == null)
            {
                throw new ArgumentNullException(nameof(runtimeEnvironment));
            }

            try
            {
                await task.ConfigureAwait(continueOnCapturedContext);
            }
            catch (Exception ex) when (runtimeEnvironment.IsRedirectableException(ex))
            {
                if (allowMute)
                {
                    runtimeEnvironment.ProcessMutedException(ex);
                }
                else
                {
                    runtimeEnvironment.ProcessUnhandledException(ex);
                }
            }
        }
    }
}
