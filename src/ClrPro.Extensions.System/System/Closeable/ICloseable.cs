// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     The closeable object. This is an extension to the <see cref="IDisposable" /> with better control over lifetime of
    ///     the object.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         You should clearly define the auto-close by GC policy in the implementation of this contract. In a case when
    ///         explicit <see cref="Close" /> call is required, the implementation should raise in the finalizer
    ///         <see cref="ExplicitCloseMissingException" /> and pass it to the
    ///         <see cref="IRuntimeEnvironment.ProcessUnhandledException" />.
    ///     </para>
    /// </remarks>
    [PublicAPI]
    [SuppressMessage(
        "Design",
        "CA1033:Interface methods should be callable by child types",
        Justification = "C# 8.0 DIM is not supported yet by FxCop")]
    public interface ICloseable : IDisposable, ICodeScopeExtension
    {
        /// <summary>
        ///     Tries to close the object synchronously, if close wasn't yet requested.
        /// </summary>
        /// <remarks>
        ///     You can use this method to perform some actions relying on the object lifetime synchronization.
        /// </remarks>
        /// <returns>
        ///     <see langword="true" /> if object has been closed by this call or <see langword="false" /> if object close was
        ///     already
        ///     requested.
        /// </returns>
        bool TryClose();

        /// <summary>
        ///     Closes the object synchronously, or raises <see cref="ObjectClosedException" /> if close was already requested.
        /// </summary>
        /// <exception cref="ObjectClosedException">The close was already requested.</exception>
        /// <remarks>
        ///     <para>Use <see cref="IDisposable.Dispose" /> method to support multiple close attempts scenarios.</para>
        /// </remarks>
        void Close()
        {
            if (!TryClose())
            {
                throw new ObjectClosedException(this);
            }
        }

        // ReSharper disable once CommentTypo
        // ReSharper disable once InheritdocInvalidUsage

        /// <inheritdoc />
        [SuppressMessage(
            "Usage",
            "CA1816:Dispose methods should call SuppressFinalize",
            Justification = "C# 8.0 DIM is not supported yet by FxCop")]
        void IDisposable.Dispose()
        {
            TryClose();
        }

        // ReSharper disable once CommentTypo
        // ReSharper disable once InheritdocInvalidUsage

        /// <inheritdoc />
        void ICodeScopeExtension.OnLoseCodeScope(Exception? exception)
        {
            Close();
        }
    }
}
