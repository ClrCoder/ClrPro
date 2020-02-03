// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Runtime.Serialization;

    /// <summary>
    ///     Exception, that is raised when missed <see cref="ICloseable.Close" /> or <see cref="IAsyncCloseable.CloseAsync" />
    ///     is detected on an <see cref="ICloseable" /> or <see cref="IAsyncCloseable" /> which enforces explicit close.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         This exception could be raised in a finalizer and then passed to some application-level error handler (for
    ///         example IRuntimeEnvironment.ProcessUnhandledException).
    ///     </para>
    /// </remarks>
    [Serializable]
    public class ExplicitCloseMissingException : InvalidOperationException
    {
        private const string ObjectWasNotClosedExceptionMessage = "Object hasn't been explicitly closed.";

        /// <summary>
        ///     Initializes a new instance of the <see cref="ExplicitCloseMissingException" /> class.
        /// </summary>
        /// <param name="sourceObject">The non-closed object.</param>
        // ReSharper disable once IntroduceOptionalParameters.Global
        public ExplicitCloseMissingException(object? sourceObject)
            : base(ObjectWasNotClosedExceptionMessage)
        {
            SourceObject = sourceObject;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ExplicitCloseMissingException" /> class.
        /// </summary>
        /// <param name="sourceObject">The non-closed object.</param>
        /// <param name="message">The message that describes the error.</param>
        public ExplicitCloseMissingException(object? sourceObject, string? message)
            : base(message ?? ObjectWasNotClosedExceptionMessage)
        {
            SourceObject = sourceObject;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ExplicitCloseMissingException" /> class.
        /// </summary>
        /// <param name="sourceObject">The non-closed object.</param>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">
        ///     The exception that is the cause of the current exception, or a null reference if no inner
        ///     exception is specified.
        /// </param>
        public ExplicitCloseMissingException(
            object? sourceObject,
            string? message,
            Exception? innerException)
            : base(message ?? ObjectWasNotClosedExceptionMessage, innerException)
        {
            SourceObject = sourceObject;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ExplicitCloseMissingException" /> class.
        /// </summary>
        /// <param name="info">
        ///     The <see cref="SerializationInfo" /> that holds the serialized object data about the exception being
        ///     thrown.
        /// </param>
        /// <param name="context">
        ///     The <see cref="StreamingContext" /> that contains contextual information about the source or
        ///     destination.
        /// </param>
        protected ExplicitCloseMissingException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        ///     The closeable object which wasn't explicitly closed.
        /// </summary>
        /// <remarks>
        ///     The property could be <see langword="null" />, for example when the exception was serialized/deserialized.
        /// </remarks>
        public object? SourceObject { get; }
    }
}
