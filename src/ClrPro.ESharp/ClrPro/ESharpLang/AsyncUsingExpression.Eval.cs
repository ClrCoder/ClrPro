// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.ESharpLang
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    /// <content>
    ///     "Eval" methods implementation.
    /// </content>
    public partial struct AsyncUsingExpression<T>
    {
        /// <summary>
        ///     Eval clause of the emulated using operator syntax (in a case when using block will be able to be an expression).
        /// </summary>
        /// <typeparam name="TResult">The eval result type.</typeparam>
        /// <param name="code">The code block of the using operator with return value.</param>
        /// <returns>The asynchronous result that the code block produces.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask<TResult> Eval<TResult>(Func<T, TResult> code)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            if (ScopeExtension == null)
            {
                return code(ScopeExtension);
            }

            Exception? exception = null;
            try
            {
                return code(ScopeExtension);
            }
            catch (Exception ex)
            {
                exception = ex;
                throw;
            }
            finally
            {
                await ScopeExtension.OnLoseCodeScopeAsync(exception);
            }
        }

        /// <summary>
        ///     Eval clause of the emulated using operator syntax (in a case when using block will be able to be an expression).
        /// </summary>
        /// <typeparam name="TResult">The eval result type.</typeparam>
        /// <param name="code">The code block of the using operator with return value.</param>
        /// <returns>The asynchronous result that the code block produces.</returns>
        /// <remarks>
        ///     <see cref="ICodeScopeExtension.IsRethrowRequired" /> will never be called. Exception will be rethrown
        ///     unconditionally.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask<TResult> Eval<TResult>(Func<TResult> code)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            if (ScopeExtension == null)
            {
                return code();
            }

            Exception? exception = null;
            try
            {
                return code();
            }
            catch (Exception ex)
            {
                exception = ex;
                throw;
            }
            finally
            {
                await ScopeExtension.OnLoseCodeScopeAsync(exception);
            }
        }
    }
}
