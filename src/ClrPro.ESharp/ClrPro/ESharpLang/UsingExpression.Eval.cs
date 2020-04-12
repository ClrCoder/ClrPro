// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.ESharpLang
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    /// <content>
    ///     "Eval" methods implementation.
    /// </content>
    public partial struct UsingExpression<TScopeExt, TUsingVar>
    {
        /// <summary>
        ///     Eval clause of the emulated using operator syntax (will not be supported by the C# language).
        /// </summary>
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="code">The code block of the using operator with return value.</param>
        /// <returns>The result that the code block produces.</returns>
        /// <remarks>
        ///     <see cref="ICodeScopeExtension.IsRethrowRequired" /> will never be called. Exception will be rethrown
        ///     unconditionally.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SuppressMessage(
            "Design",
            "CA1062:Validate arguments of public methods",
            Justification = "The argument has been validated.")]
        public TResult Eval<TResult>(Func<TResult> code)
        {
            if (code == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.code);
            }

            if (ScopeExtension == null)
            {
                return code.Invoke();
            }

            Exception? exception = null;
            try
            {
                return code.Invoke();
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
        /// <typeparam name="TResult">The result type.</typeparam>
        /// <param name="code">The code block of the using operator with return value.</param>
        /// <returns>The result that the code block produces.</returns>
        /// <remarks>
        ///     <see cref="ICodeScopeExtension.IsRethrowRequired" /> will never be called. Exception will be rethrown
        ///     unconditionally.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SuppressMessage(
            "Design",
            "CA1062:Validate arguments of public methods",
            Justification = "The argument has been validated.")]
        public TResult Eval<TResult>(Func<TUsingVar, TResult> code)
        {
            if (code == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.code);
            }

            if (ScopeExtension == null)
            {
                return code.Invoke(UsingVar);
            }

            Exception? exception = null;
            try
            {
                return code.Invoke(UsingVar);
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
