// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     The <see cref="ICloseable" /> object which can be closed forcefully with the specification of a error.
    /// </summary>
    [PublicAPI]
    [SuppressMessage(
        "Design",
        "CA1033:Interface methods should be callable by child types",
        Justification = "C# 8.0 DIM is not supported yet by FxCop")]
    public interface ITerminable : ICloseable
    {
        /// <summary>
        ///     The termination reason exception.
        /// </summary>
        Exception? TerminateReason { get; }

        /// <summary>
        ///     Terminates the object with the specified, if it hasn't been closed or terminated yet.
        /// </summary>
        /// <param name="reasonException">The termination reason exception.</param>
        /// <returns>
        ///     <see langword="true" /> if object has been terminated by this call or <see langword="false" /> if object was
        ///     already closed/terminated.
        /// </returns>
        bool TryTerminate(Exception reasonException)
        {
            return TryClose(reasonException);
        }

        /// <summary>
        ///     Terminates the object synchronously, or raises <see cref="ObjectClosedException" /> if the object was already
        ///     closed/terminated.
        /// </summary>
        /// <exception cref="ObjectClosedException">The close/terminate was already requested.</exception>
        /// <remarks>
        ///     <para>Use <see cref="IDisposable.Dispose" /> method to support multiple close attempts scenarios.</para>
        /// </remarks>
        void Terminate(Exception reasonException)
        {
            if (!TryTerminate(reasonException))
            {
                throw new ObjectClosedException(this);
            }
        }

        /// <summary>
        ///     Tries to close the object synchronously providing terminate reason exception or <see langword="null" /> in a case
        ///     of <see cref="ICloseable.TryClose" /> call.
        /// </summary>
        /// <param name="reasonException">The terminate reason exception.</param>
        /// <returns>
        ///     <see langword="true" /> if object has been closed/terminated by this call or <see langword="false" /> if object was
        ///     already closed/terminated.
        /// </returns>
        protected bool TryClose(Exception? reasonException);

        // ReSharper disable once CommentTypo
        // ReSharper disable once InheritdocInvalidUsage

        /// <inheritdoc />
        bool ICloseable.TryClose()
        {
            return TryClose(null);
        }

        // ReSharper disable once CommentTypo
        // ReSharper disable once InheritdocInvalidUsage

        /// <inheritdoc />
        void ICodeScopeExtension.OnLoseCodeScope(Exception? exception)
        {
            if (exception != null)
            {
                Terminate(exception);
            }
            else
            {
                Close();
            }
        }
    }
}
