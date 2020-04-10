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
    // ReSharper disable once UnusedTypeParameter
    public partial struct AsyncUsingExpression<TScopeExt, TUsingVar>
    {
        /// <summary>
        ///     Eval clause of the emulated using operator syntax (will not be supported by the C# language).
        /// </summary>
        /// <typeparam name="TResult">The eval result type.</typeparam>
        /// <param name="code">The code block of the using operator with return value.</param>
        /// <returns>The asynchronous result that the code block produces.</returns>
        /// <remarks>
        ///     <see cref="ICodeScopeExtension.IsRethrowRequired" /> will never be called. Exception will be rethrown
        ///     unconditionally.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask<TResult> Eval<TResult>(Func<TUsingVar, TResult> code)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            if (ScopeExtension == null)
            {
                return code(UsingVar);
            }

            Exception? exception = null;
            try
            {
                return code(UsingVar);
            }
            catch (Exception ex)
            {
                exception = ex;
                throw;
            }
            finally
            {
                await ScopeExtension.OnLoseCodeScopeAsync(exception).ConfigureAwait(false);
            }
        }

        /// <summary>
        ///     Eval clause of the emulated using operator syntax (will not be supported by the C# language).
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
                await ScopeExtension.OnLoseCodeScopeAsync(exception).ConfigureAwait(false);
            }
        }
    }
}
