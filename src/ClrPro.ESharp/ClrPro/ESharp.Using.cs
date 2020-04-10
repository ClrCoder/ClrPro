// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro
{
    using System.Runtime.CompilerServices;
    using ClrPro.ESharpLang;
    using JetBrains.Annotations;

    // TODO: Add Dispose ownership annotation when it will be available: https://github.com/dotnet/runtime/issues/29631

    /// <summary>
    ///     Emulation# (E#) - Upcoming C# language features polyfills and useful language extensions.
    /// </summary>
    /// <remarks>
    ///     Use this line to enable extensions in your code.
    ///     <code>using static ClrPro.ESharp;</code>
    /// </remarks>
    [PublicAPI]
    public static partial class ESharp
    {
        /// <summary>
        ///     Advanced using operator with supports <see cref="ICodeScopeExtension" />.
        /// </summary>
        /// <typeparam name="T">The type of the scope extension object.</typeparam>
        /// <param name="scopeExtension">The scope extension (handler of the code scope events).</param>
        /// <returns>The chain syntax context.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UsingExpression<T, T> Using<T>(T scopeExtension)
            where T : ICodeScopeExtension?
        {
            return new UsingExpression<T, T>
            {
                ScopeExtension = scopeExtension,
                UsingVar = scopeExtension,
            };
        }

        /// <summary>
        ///     Advanced using operator with supports <see cref="IAsyncCodeScopeExtension" /> contracts.
        /// </summary>
        /// <typeparam name="T">The type of the scope extension object.</typeparam>
        /// <param name="scopeExtension">The scope extension (handler of the code scope events).</param>
        /// <returns>The chain syntax context.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AsyncUsingExpression<T, T> UsingAsync<T>(T scopeExtension)
            where T : IAsyncCodeScopeExtension?
        {
            return new AsyncUsingExpression<T, T>
            {
                ScopeExtension = scopeExtension,
                UsingVar = scopeExtension,
            };
        }
    }
}
