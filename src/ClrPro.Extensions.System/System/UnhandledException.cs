// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics;
    using System.Runtime.Serialization;

    /// <summary>
    ///     The envelop for an unhandled exception. <see cref="Exception.InnerException" /> always contains an exception that
    ///     wasn't handled.
    /// </summary>
    /// <remarks>
    ///     <para>This design helps to track origin where and why exception wasn't handled.</para>
    ///     <para>
    ///         Raising of this exception could be a part of a <see cref="IRuntimeEnvironment.ProcessUnhandledException" />
    ///         solution. By default <see cref="IRuntimeEnvironment" /> treat this exception as non redirectable.
    ///     </para>
    /// </remarks>
    [Serializable]
    public class UnhandledException : Exception
    {
        private const string ExceptionNotHandledByApplication = "Exception wasn't handled by the application.";

        /// <summary>
        ///     Initializes a new instance of the <see cref="UnhandledException" /> class.
        /// </summary>
        /// <param name="innerException">The unhandled exception.</param>
        public UnhandledException(Exception innerException)
            : base(ExceptionNotHandledByApplication, innerException)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="UnhandledException" /> class.
        /// </summary>
        /// <param name="message">The message for the unhandled exception event.</param>
        /// <param name="innerException">The unhandled exception.</param>
        public UnhandledException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="UnhandledException" /> class with serialized data.
        /// </summary>
        /// <param name="info">
        ///     The <see cref="SerializationInfo" /> that holds the serialized object data about the exception being
        ///     thrown.
        /// </param>
        /// <param name="context">
        ///     The <see cref="StreamingContext" /> that contains contextual information about the source or
        ///     destination.
        /// </param>
        protected UnhandledException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        ///     Wraps exception into <see cref="UnhandledException" /> if it's not yet <see cref="UnhandledException" />.
        /// </summary>
        /// <param name="exception">The exception to wrap.</param>
        /// <returns>The exception wrapped in the <see cref="UnhandledException" /> envelop.</returns>
        [DebuggerStepThrough]
        public static UnhandledException Wrap(Exception exception)
        {
            if (!(exception is UnhandledException unhandledException))
            {
                try
                {
                    // Throw helper is useless here.
                    throw new UnhandledException(exception);
                }
                catch (UnhandledException e)
                {
                    unhandledException = e;
                }
            }

            return unhandledException;
        }
    }
}
