// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.ESharpLang
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    /// <content>
    ///     "EvalAsync" methods implementation.
    /// </content>
    public partial struct AsyncUsingExpression<T>
    {
        /// <summary>
        ///     Eval clause of the emulated using operator syntax (in a case when using block will be able to be an expression).
        /// </summary>
        /// <typeparam name="TResult">The eval result type.</typeparam>
        /// <param name="code">The code block of the using operator with return value.</param>
        /// <param name="continueOnCapturedContext">
        ///     <see langword="true" /> to attempt to marshal the continuation back
        ///     to the captured context; otherwise, <see langword="false" /> .
        /// </param>
        /// <returns>The asynchronous result that the code block produces.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask<TResult> EvalAsync<TResult>(
            Func<ValueTask<TResult>> code,
            bool continueOnCapturedContext = true)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            if (ScopeExtension == null)
            {
                return await code().ConfigureAwait(continueOnCapturedContext);
            }

            Exception? exception = null;
            try
            {
                return await code().ConfigureAwait(continueOnCapturedContext);
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
        /// <param name="continueOnCapturedContext">
        ///     <see langword="true" /> to attempt to marshal the continuation back
        ///     to the captured context; otherwise, <see langword="false" /> .
        /// </param>
        /// <returns>The asynchronous result that the code block produces.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask<TResult> EvalAsync<TResult>(
            Func<T, ValueTask<TResult>> code,
            bool continueOnCapturedContext = true)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            if (ScopeExtension == null)
            {
                return await code(ScopeExtension).ConfigureAwait(continueOnCapturedContext);
            }

            Exception? exception = null;
            try
            {
                return await code(ScopeExtension).ConfigureAwait(continueOnCapturedContext);
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
        /// <param name="continueOnCapturedContext">
        ///     <see langword="true" /> to attempt to marshal the continuation back
        ///     to the captured context; otherwise, <see langword="false" /> .
        /// </param>
        /// <returns>The asynchronous result that the code block produces.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask<TResult> EvalTAsync<TResult>(
            Func<Task<TResult>> code,
            bool continueOnCapturedContext = true)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            if (ScopeExtension == null)
            {
                return await code().ConfigureAwait(continueOnCapturedContext);
            }

            Exception? exception = null;
            try
            {
                return await code().ConfigureAwait(continueOnCapturedContext);
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
        /// <param name="continueOnCapturedContext">
        ///     <see langword="true" /> to attempt to marshal the continuation back
        ///     to the captured context; otherwise, <see langword="false" /> .
        /// </param>
        /// <returns>The asynchronous result that the code block produces.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async ValueTask<TResult> EvalTAsync<TResult>(
            Func<T, Task<TResult>> code,
            bool continueOnCapturedContext = true)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            if (ScopeExtension == null)
            {
                return await code(ScopeExtension).ConfigureAwait(continueOnCapturedContext);
            }

            Exception? exception = null;
            try
            {
                return await code(ScopeExtension).ConfigureAwait(continueOnCapturedContext);
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
