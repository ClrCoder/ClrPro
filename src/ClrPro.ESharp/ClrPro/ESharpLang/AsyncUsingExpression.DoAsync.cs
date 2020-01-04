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
    public partial struct AsyncUsingExpression<T>
    {
        /// <summary>
        ///     Do clause of the using operator syntax.
        /// </summary>
        /// <param name="code">The code block of the using operator.</param>
        /// <param name="continueOnCapturedContext">
        ///     <see langword="true" /> to attempt to marshal the continuation back
        ///     to the captured context; otherwise, <see langword="false" /> .
        /// </param>
        /// <returns>The asynchronous operation task.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask DoAsync(Func<ValueTask>? code, bool continueOnCapturedContext = true)
        {
            if (ScopeExtension == null)
            {
                if (code != null)
                {
                    await code().ConfigureAwait(continueOnCapturedContext);
                }
            }
            else
            {
                var codeExecuted = false;
                try
                {
                    if (code != null)
                    {
                        await code().ConfigureAwait(continueOnCapturedContext);
                    }

                    codeExecuted = true;
                }
                catch (Exception ex)
                {
                    // This method can throw exception and override current one.
                    await ScopeExtension.OnLoseCodeScopeAsync(ex);

                    if (ScopeExtension.IsRethrowRequired)
                    {
                        throw;
                    }
                }

                if (codeExecuted)
                {
                    await ScopeExtension.OnLoseCodeScopeAsync(null);
                }
            }
        }

        /// <summary>
        ///     Do clause of the using operator syntax.
        /// </summary>
        /// <param name="code">The code block of the using operator.</param>
        /// <param name="continueOnCapturedContext">
        ///     <see langword="true" /> to attempt to marshal the continuation back
        ///     to the captured context; otherwise, <see langword="false" /> .
        /// </param>
        /// <returns>The asynchronous operation task.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask DoAsync(Func<T, ValueTask>? code, bool continueOnCapturedContext = true)
        {
            if (ScopeExtension == null)
            {
                if (code != null)
                {
                    await code(ScopeExtension).ConfigureAwait(continueOnCapturedContext);
                }
            }
            else
            {
                var codeExecuted = false;
                try
                {
                    if (code != null)
                    {
                        await code(ScopeExtension).ConfigureAwait(continueOnCapturedContext);
                    }

                    codeExecuted = true;
                }
                catch (Exception ex)
                {
                    // This method can throw exception and override current one.
                    await ScopeExtension.OnLoseCodeScopeAsync(ex);

                    if (ScopeExtension.IsRethrowRequired)
                    {
                        throw;
                    }
                }

                if (codeExecuted)
                {
                    await ScopeExtension.OnLoseCodeScopeAsync(null);
                }
            }
        }

        /// <summary>
        ///     Do clause of the using operator syntax.
        /// </summary>
        /// <param name="code">The code block of the using operator.</param>
        /// <param name="continueOnCapturedContext">
        ///     <see langword="true" /> to attempt to marshal the continuation back
        ///     to the captured context; otherwise, <see langword="false" /> .
        /// </param>
        /// <returns>The asynchronous operation task.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask DoTAsync(Func<Task>? code, bool continueOnCapturedContext = true)
        {
            if (ScopeExtension == null)
            {
                if (code != null)
                {
                    await code().ConfigureAwait(continueOnCapturedContext);
                }
            }
            else
            {
                var codeExecuted = false;
                try
                {
                    if (code != null)
                    {
                        await code().ConfigureAwait(continueOnCapturedContext);
                    }

                    codeExecuted = true;
                }
                catch (Exception ex)
                {
                    // This method can throw exception and override current one.
                    await ScopeExtension.OnLoseCodeScopeAsync(ex);

                    if (ScopeExtension.IsRethrowRequired)
                    {
                        throw;
                    }
                }

                if (codeExecuted)
                {
                    await ScopeExtension.OnLoseCodeScopeAsync(null);
                }
            }
        }

        /// <summary>
        ///     Do clause of the using operator syntax.
        /// </summary>
        /// <param name="code">The code block of the using operator.</param>
        /// <param name="continueOnCapturedContext">
        ///     <see langword="true" /> to attempt to marshal the continuation back
        ///     to the captured context; otherwise, <see langword="false" /> .
        /// </param>
        /// <returns>The asynchronous operation task.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask DoTAsync(Func<T, Task>? code, bool continueOnCapturedContext = true)
        {
            if (ScopeExtension == null)
            {
                if (code != null)
                {
                    await code(ScopeExtension).ConfigureAwait(continueOnCapturedContext);
                }
            }
            else
            {
                var codeExecuted = false;
                try
                {
                    if (code != null)
                    {
                        await code(ScopeExtension).ConfigureAwait(continueOnCapturedContext);
                    }

                    codeExecuted = true;
                }
                catch (Exception ex)
                {
                    await ScopeExtension.OnLoseCodeScopeAsync(ex);

                    if (ScopeExtension.IsRethrowRequired)
                    {
                        throw;
                    }
                }

                if (codeExecuted)
                {
                    await ScopeExtension.OnLoseCodeScopeAsync(null);
                }
            }
        }
    }
}
