// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.ESharpLang
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>
    ///     Using operator chain syntax context before ".Do" clause.
    /// </summary>
    /// <remarks>
    ///     The ESharp.Using methods family can't provide maximal performance. The aim is advanced syntax.
    /// </remarks>
    /// <typeparam name="TScopeExt">The type of the scope extension.</typeparam>
    /// <typeparam name="TUsingVar">The type of the variable that passed to the using operator.</typeparam>
    [PublicAPI]
    [SuppressMessage(
        "Performance",
        "CA1815:Override equals and operator equals on value types",
        Justification = "This is syntax sugar only construct.")]
    public partial struct AsyncUsingExpression<TScopeExt, TUsingVar>
        where TScopeExt : IAsyncCodeScopeExtension?
    {
        internal TScopeExt ScopeExtension;
        internal TUsingVar UsingVar;

        /// <summary>
        ///     Do clause of the using operator syntax.
        /// </summary>
        /// <param name="code">The code block of the using operator.</param>
        /// <returns>The asynchronous operation task.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask Do(Action? code = null)
        {
            if (ScopeExtension == null)
            {
                code?.Invoke();
            }
            else
            {
                var codeExecuted = false;
                try
                {
                    code?.Invoke();
                    codeExecuted = true;
                }
                catch (Exception ex)
                {
                    // This method can throw exception and override current one.
                    await ScopeExtension.OnLoseCodeScopeAsync(ex).ConfigureAwait(false);

                    if (ScopeExtension.IsRethrowRequired)
                    {
                        throw;
                    }
                }

                if (codeExecuted)
                {
                    await ScopeExtension.OnLoseCodeScopeAsync(null).ConfigureAwait(false);
                }
            }
        }

        /// <summary>
        ///     Do clause of the using operator syntax.
        /// </summary>
        /// <param name="code">The code block of the using operator.</param>
        /// <returns>The asynchronous operation task.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask Do(Action<TUsingVar>? code)
        {
            if (ScopeExtension == null)
            {
                code?.Invoke(UsingVar);
            }
            else
            {
                var codeExecuted = false;
                try
                {
                    code?.Invoke(UsingVar);
                    codeExecuted = true;
                }
                catch (Exception ex)
                {
                    // This method can throw exception and override current one.
                    await ScopeExtension.OnLoseCodeScopeAsync(ex).ConfigureAwait(false);

                    if (ScopeExtension.IsRethrowRequired)
                    {
                        throw;
                    }
                }

                if (codeExecuted)
                {
                    await ScopeExtension.OnLoseCodeScopeAsync(null).ConfigureAwait(false);
                }
            }
        }
    }
}
