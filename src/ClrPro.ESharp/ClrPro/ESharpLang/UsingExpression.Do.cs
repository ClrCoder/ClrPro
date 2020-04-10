// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.ESharpLang
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     Using operator chain syntax context before ".Do" clause.
    /// </summary>
    /// <remarks>
    ///     The ESharp.Using methods family can't provide maximal performance. The aim is advanced syntax.
    /// </remarks>
    /// <typeparam name="T">The type of the scope extension.</typeparam>
    [PublicAPI]
    [SuppressMessage(
        "Performance",
        "CA1815:Override equals and operator equals on value types",
        Justification = "This is syntax sugar only construct.")]
    public partial struct UsingExpression<T>
        where T : ICodeScopeExtension?
    {
        internal T ScopeExtension;

        /// <summary>
        ///     Do clause of the using operator syntax.
        /// </summary>
        /// <param name="code">The code block of the using operator.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Do(Action? code = null)
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
                    ScopeExtension.OnLoseCodeScope(ex);

                    if (ScopeExtension.IsRethrowRequired)
                    {
                        throw;
                    }
                }

                if (codeExecuted)
                {
                    ScopeExtension.OnLoseCodeScope(null);
                }
            }
        }

        /// <summary>
        ///     Do clause of the using operator syntax.
        /// </summary>
        /// <param name="code">The code block of the using operator.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Do(Action<T>? code)
        {
            if (ScopeExtension == null)
            {
                code?.Invoke(ScopeExtension);
            }
            else
            {
                var codeExecuted = false;
                try
                {
                    code?.Invoke(ScopeExtension);
                    codeExecuted = true;
                }
                catch (Exception ex)
                {
                    // This method can throw exception and override current one.
                    ScopeExtension.OnLoseCodeScope(ex);

                    if (ScopeExtension.IsRethrowRequired)
                    {
                        throw;
                    }
                }

                if (codeExecuted)
                {
                    ScopeExtension.OnLoseCodeScope(null);
                }
            }
        }
    }
}
