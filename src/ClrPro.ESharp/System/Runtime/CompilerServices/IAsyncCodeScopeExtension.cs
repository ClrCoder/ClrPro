// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Runtime.CompilerServices
{
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>
    ///     Scoped language construct asynchronous extension, primarily <see langword="using" /> operator.
    /// </summary>
    [PublicAPI]
    public interface IAsyncCodeScopeExtension
    {
        /// <summary>
        ///     Gets flag indicating that exception should be rethrown.
        /// </summary>
        /// <remarks>
        ///     In a case of exception, this property checked after the <see cref="OnLoseCodeScopeAsync" /> call to determine if
        ///     exception should be rethrown.
        /// </remarks>
#if NETSTANDARD2_0
        bool IsRethrowRequired { get; }
#else
        bool IsRethrowRequired => true;
#endif

        /// <summary>
        ///     Asynchronously executed by a language construct when the language construct loses its scope.
        /// </summary>
        /// <param name="exception">
        ///     Exception that was caused the scope loosing, or <see langword="null" /> for a normal execution
        ///     flow.
        /// </param>
        /// <returns>The async operation task.</returns>
        /// <remarks>
        ///     You can throw your own exception from this method, it will override the exception from the code block.
        /// </remarks>
        ValueTask OnLoseCodeScopeAsync(Exception? exception);
    }
}
