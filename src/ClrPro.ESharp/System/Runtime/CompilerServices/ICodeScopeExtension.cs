// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Runtime.CompilerServices
{
    using JetBrains.Annotations;

    /// <summary>
    ///     Scoped language construct extension, primarily <see langword="using" /> statement.
    /// </summary>
    /// <remarks>
    ///     <para><see cref="IDisposable" /> should start to inherit this interface.</para>
    ///     <para>
    ///         C# compiler should receive an opt-out by default option to call OnLoseCodeScope instead of Dispose in the
    ///         using blocks.
    ///     </para>
    /// </remarks>
    [PublicAPI]
    public interface ICodeScopeExtension
    {
        /// <summary>
        ///     Gets flag indicating that exception should be rethrown.
        /// </summary>
        /// <remarks>
        ///     In a case of exception, this property checked after the <see cref="OnLoseCodeScope" /> to determine if exception
        ///     should be rethrown.
        /// </remarks>
#if NETSTANDARD2_0
        bool IsRethrowRequired { get; }
#else
        bool IsRethrowRequired => true;
#endif

        /// <summary>
        ///     Executed by a language construct when the language construct loses its scope.
        /// </summary>
        /// <param name="exception">
        ///     Exception that was caused the scope loosing, or <see langword="null" /> for a normal execution
        ///     flow.
        /// </param>
        /// <remarks>
        ///     You can throw your own exception from this method, it will override the exception from the code block.
        /// </remarks>
        void OnLoseCodeScope(Exception? exception);
    }
}
