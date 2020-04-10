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
    public partial struct UsingExpression<T>
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
        public async ValueTask<TResult> EvalAsync<TResult>(
            Func<ValueTask<TResult>> code)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            if (ScopeExtension == null)
            {
                return await code().ConfigureAwait(false);
            }

            Exception? exception = null;
            try
            {
                return await code().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                exception = ex;
                throw;
            }
            finally
            {
                ScopeExtension.OnLoseCodeScope(exception);
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
        public async ValueTask<TResult> EvalAsync<TResult>(
            Func<T, ValueTask<TResult>> code)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            if (ScopeExtension == null)
            {
                return await code(ScopeExtension).ConfigureAwait(false);
            }

            Exception? exception = null;
            try
            {
                return await code(ScopeExtension).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                exception = ex;
                throw;
            }
            finally
            {
                ScopeExtension.OnLoseCodeScope(exception);
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
        public async ValueTask<TResult> EvalTAsync<TResult>(
            Func<Task<TResult>> code)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            if (ScopeExtension == null)
            {
                return await code().ConfigureAwait(false);
            }

            Exception? exception = null;
            try
            {
                return await code().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                exception = ex;
                throw;
            }
            finally
            {
                ScopeExtension.OnLoseCodeScope(exception);
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
        public async ValueTask<TResult> EvalTAsync<TResult>(
            Func<T, Task<TResult>> code)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            if (ScopeExtension == null)
            {
                return await code(ScopeExtension).ConfigureAwait(false);
            }

            Exception? exception = null;
            try
            {
                return await code(ScopeExtension).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                exception = ex;
                throw;
            }
            finally
            {
                ScopeExtension.OnLoseCodeScope(exception);
            }
        }
    }
}
