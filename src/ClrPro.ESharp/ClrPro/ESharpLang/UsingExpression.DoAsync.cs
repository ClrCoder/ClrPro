// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.ESharpLang
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    /// <content>
    ///     "DoAsync" methods implementation.
    /// </content>
    public partial struct UsingExpression<T>
    {
        /// <summary>
        ///     Do clause of the using operator syntax.
        /// </summary>
        /// <param name="code">The code block of the using operator.</param>
        /// <returns>The asynchronous operation task.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask DoAsync(Func<ValueTask>? code)
        {
            if (ScopeExtension == null)
            {
                if (code != null)
                {
                    await code().ConfigureAwait(false);
                }
            }
            else
            {
                var codeExecuted = false;
                try
                {
                    if (code != null)
                    {
                        await code().ConfigureAwait(false);
                    }

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
        /// <returns>The asynchronous operation task.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask DoAsync(Func<T, ValueTask>? code)
        {
            if (ScopeExtension == null)
            {
                if (code != null)
                {
                    await code(ScopeExtension).ConfigureAwait(false);
                }
            }
            else
            {
                var codeExecuted = false;
                try
                {
                    if (code != null)
                    {
                        await code(ScopeExtension).ConfigureAwait(false);
                    }

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
        /// <returns>The asynchronous operation task.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask DoTAsync(Func<Task>? code)
        {
            if (ScopeExtension == null)
            {
                if (code != null)
                {
                    await code().ConfigureAwait(false);
                }
            }
            else
            {
                var codeExecuted = false;
                try
                {
                    if (code != null)
                    {
                        await code().ConfigureAwait(false);
                    }

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
        /// <returns>The asynchronous operation task.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask DoTAsync(Func<T, ValueTask>? code)
        {
            if (ScopeExtension == null)
            {
                if (code != null)
                {
                    await code(ScopeExtension).ConfigureAwait(false);
                }
            }
            else
            {
                var codeExecuted = false;
                try
                {
                    if (code != null)
                    {
                        await code(ScopeExtension).ConfigureAwait(false);
                    }

                    codeExecuted = true;
                }
                catch (Exception ex)
                {
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
