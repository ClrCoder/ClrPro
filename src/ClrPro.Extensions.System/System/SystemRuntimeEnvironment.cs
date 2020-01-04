// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Runtime.ExceptionServices;

    /// <summary>
    ///     <see cref="IRuntimeEnvironment" /> implementation that is most close to the CLR Runtime behavior.
    /// </summary>
    public class SystemRuntimeEnvironment : IRuntimeEnvironment
    {
        /// <inheritdoc />
        public void ProcessUnhandledException(Exception unhandledException)
        {
            ExceptionDispatchInfo.Capture(unhandledException).Throw();
        }
    }
}
