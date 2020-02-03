// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Runtime.Serialization;
    using JetBrains.Annotations;

    /// <summary>
    ///     The error while trying to perform an operation on non-alive <see cref="ICloseable" /> or
    ///     <see cref="IAsyncCloseable" /> object.
    /// </summary>
    /// <remarks>
    ///     <param>
    ///         This exception should be called when current status is <see cref="ClosingStatus.Closing" /> or
    ///         <see cref="ClosingStatus.Closed" />. Some operations could be allowed in the state
    ///         <see cref="ClosingStatus.CloseRequested" />.
    ///     </param>
    /// </remarks>
    [PublicAPI]
    [Serializable]
    public class ObjectClosedException : ObjectDisposedException
    {
        private const string ObjectClosedExceptionMessage = "Object already closed.";

        /// <summary>
        ///     Initializes a new instance of the <see cref="ObjectClosedException" /> class.
        /// </summary>
        /// <param name="sourceObject">The non-alive object.</param>
        // ReSharper disable once IntroduceOptionalParameters.Global
        public ObjectClosedException(object? sourceObject)
            : base(null, ObjectClosedExceptionMessage)
        {
            SourceObject = sourceObject;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ObjectClosedException" /> class.
        /// </summary>
        /// <param name="sourceObject">The non-alive object.</param>
        /// <param name="message">The message that describes the error.</param>
        public ObjectClosedException(object? sourceObject, string? message)
            : base(message ?? ObjectClosedExceptionMessage)
        {
            SourceObject = sourceObject;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ObjectClosedException" /> class.
        /// </summary>
        /// <param name="sourceObject">The non-alive object.</param>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">
        ///     The exception that is the cause of the current exception, or a null reference if no inner
        ///     exception is specified.
        /// </param>
        public ObjectClosedException(
            object? sourceObject,
            string? message,
            Exception? innerException)
            : base(message ?? ObjectClosedExceptionMessage, innerException)
        {
            SourceObject = sourceObject;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ObjectClosedException" /> class.
        /// </summary>
        /// <param name="info">
        ///     The <see cref="SerializationInfo" /> that holds the serialized object data about the exception being
        ///     thrown.
        /// </param>
        /// <param name="context">
        ///     The <see cref="StreamingContext" /> that contains contextual information about the source or
        ///     destination.
        /// </param>
        protected ObjectClosedException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        ///     The non-alive object.
        /// </summary>
        /// <remarks>
        ///     The property could be <see langword="null" />, for example when the exception was serialized/deserialized.
        /// </remarks>
        public object? SourceObject { get; }
    }
}
