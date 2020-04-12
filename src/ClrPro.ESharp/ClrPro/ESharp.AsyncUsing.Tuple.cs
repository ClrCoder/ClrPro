// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using ClrPro.ESharpLang;

    /// <content>
    ///     AsyncUsing syntax for the tuples with the first item disposable.
    /// </content>
    public static partial class ESharp
    {
        /// <summary>
        ///     Advanced using operator with supports <see cref="IAsyncCodeScopeExtension" /> contracts.
        /// </summary>
        /// <typeparam name="T1">The tuple item 1 type.</typeparam>
        /// <param name="tuple">The tuple with the disposable first item.</param>
        /// <returns>The chain syntax context.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SuppressMessage(
            "Design",
            "CA1062:Validate arguments of public methods",
            Justification = "The argument has been validated.")]
        public static AsyncUsingExpression<T1, Tuple<T1>> UsingAsync<T1>(Tuple<T1> tuple)
            where T1 : IAsyncCodeScopeExtension?
        {
            if (tuple == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tuple);
            }

            return new AsyncUsingExpression<T1, Tuple<T1>>
            {
                ScopeExtension = tuple.Item1,
                UsingVar = tuple,
            };
        }

        /// <summary>
        ///     Advanced using operator with supports <see cref="IAsyncCodeScopeExtension" /> contracts.
        /// </summary>
        /// <typeparam name="T1">The tuple item 1 type.</typeparam>
        /// <typeparam name="T2">The tuple item 2 type.</typeparam>
        /// <param name="tuple">The tuple with the disposable first item.</param>
        /// <returns>The chain syntax context.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SuppressMessage(
            "Design",
            "CA1062:Validate arguments of public methods",
            Justification = "The argument has been validated.")]
        public static AsyncUsingExpression<T1, Tuple<T1, T2>> UsingAsync<T1, T2>(Tuple<T1, T2> tuple)
            where T1 : IAsyncCodeScopeExtension?
        {
            if (tuple == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tuple);
            }

            return new AsyncUsingExpression<T1, Tuple<T1, T2>>
            {
                ScopeExtension = tuple.Item1,
                UsingVar = tuple,
            };
        }

        /// <summary>
        ///     Advanced using operator with supports <see cref="IAsyncCodeScopeExtension" /> contracts.
        /// </summary>
        /// <typeparam name="T1">The tuple item 1 type.</typeparam>
        /// <typeparam name="T2">The tuple item 2 type.</typeparam>
        /// <typeparam name="T3">The tuple item 3 type.</typeparam>
        /// <param name="tuple">The tuple with the disposable first item.</param>
        /// <returns>The chain syntax context.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SuppressMessage(
            "Design",
            "CA1062:Validate arguments of public methods",
            Justification = "The argument has been validated.")]
        public static AsyncUsingExpression<T1, Tuple<T1, T2, T3>> UsingAsync<T1, T2, T3>(Tuple<T1, T2, T3> tuple)
            where T1 : IAsyncCodeScopeExtension?
        {
            if (tuple == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tuple);
            }

            return new AsyncUsingExpression<T1, Tuple<T1, T2, T3>>
            {
                ScopeExtension = tuple.Item1,
                UsingVar = tuple,
            };
        }

        /// <summary>
        ///     Advanced using operator with supports <see cref="IAsyncCodeScopeExtension" /> contracts.
        /// </summary>
        /// <typeparam name="T1">The tuple item 1 type.</typeparam>
        /// <typeparam name="T2">The tuple item 2 type.</typeparam>
        /// <typeparam name="T3">The tuple item 3 type.</typeparam>
        /// <typeparam name="T4">The tuple item 4 type.</typeparam>
        /// <param name="tuple">The tuple with the disposable first item.</param>
        /// <returns>The chain syntax context.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SuppressMessage(
            "Design",
            "CA1062:Validate arguments of public methods",
            Justification = "The argument has been validated.")]
        public static AsyncUsingExpression<T1, Tuple<T1, T2, T3, T4>> UsingAsync<T1, T2, T3, T4>(
            Tuple<T1, T2, T3, T4> tuple)
            where T1 : IAsyncCodeScopeExtension?
        {
            if (tuple == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tuple);
            }

            return new AsyncUsingExpression<T1, Tuple<T1, T2, T3, T4>>
            {
                ScopeExtension = tuple.Item1,
                UsingVar = tuple,
            };
        }

        /// <summary>
        ///     Advanced using operator with supports <see cref="IAsyncCodeScopeExtension" /> contracts.
        /// </summary>
        /// <typeparam name="T1">The tuple item 1 type.</typeparam>
        /// <typeparam name="T2">The tuple item 2 type.</typeparam>
        /// <typeparam name="T3">The tuple item 3 type.</typeparam>
        /// <typeparam name="T4">The tuple item 4 type.</typeparam>
        /// <typeparam name="T5">The tuple item 5 type.</typeparam>
        /// <param name="tuple">The tuple with the disposable first item.</param>
        /// <returns>The chain syntax context.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SuppressMessage(
            "Design",
            "CA1062:Validate arguments of public methods",
            Justification = "The argument has been validated.")]
        public static AsyncUsingExpression<T1, Tuple<T1, T2, T3, T4, T5>> UsingAsync<T1, T2, T3, T4, T5>(
            Tuple<T1, T2, T3, T4, T5> tuple)
            where T1 : IAsyncCodeScopeExtension?
        {
            if (tuple == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tuple);
            }

            return new AsyncUsingExpression<T1, Tuple<T1, T2, T3, T4, T5>>
            {
                ScopeExtension = tuple.Item1,
                UsingVar = tuple,
            };
        }

        /// <summary>
        ///     Advanced using operator with supports <see cref="IAsyncCodeScopeExtension" /> contracts.
        /// </summary>
        /// <typeparam name="T1">The tuple item 1 type.</typeparam>
        /// <typeparam name="T2">The tuple item 2 type.</typeparam>
        /// <typeparam name="T3">The tuple item 3 type.</typeparam>
        /// <typeparam name="T4">The tuple item 4 type.</typeparam>
        /// <typeparam name="T5">The tuple item 5 type.</typeparam>
        /// <typeparam name="T6">The tuple item 6 type.</typeparam>
        /// <param name="tuple">The tuple with the disposable first item.</param>
        /// <returns>The chain syntax context.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SuppressMessage(
            "Design",
            "CA1062:Validate arguments of public methods",
            Justification = "The argument has been validated.")]
        public static AsyncUsingExpression<T1, Tuple<T1, T2, T3, T4, T5, T6>> UsingAsync<T1, T2, T3, T4, T5, T6>(
            Tuple<T1, T2, T3, T4, T5, T6> tuple)
            where T1 : IAsyncCodeScopeExtension?
        {
            if (tuple == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tuple);
            }

            return new AsyncUsingExpression<T1, Tuple<T1, T2, T3, T4, T5, T6>>
            {
                ScopeExtension = tuple.Item1,
                UsingVar = tuple,
            };
        }

        /// <summary>
        ///     Advanced using operator with supports <see cref="IAsyncCodeScopeExtension" /> contracts.
        /// </summary>
        /// <typeparam name="T1">The tuple item 1 type.</typeparam>
        /// <typeparam name="T2">The tuple item 2 type.</typeparam>
        /// <typeparam name="T3">The tuple item 3 type.</typeparam>
        /// <typeparam name="T4">The tuple item 4 type.</typeparam>
        /// <typeparam name="T5">The tuple item 5 type.</typeparam>
        /// <typeparam name="T6">The tuple item 6 type.</typeparam>
        /// <typeparam name="T7">The tuple item 7 type.</typeparam>
        /// <param name="tuple">The tuple with the disposable first item.</param>
        /// <returns>The chain syntax context.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SuppressMessage(
            "Design",
            "CA1062:Validate arguments of public methods",
            Justification = "The argument has been validated.")]
        public static AsyncUsingExpression<T1, Tuple<T1, T2, T3, T4, T5, T6, T7>>
            UsingAsync<T1, T2, T3, T4, T5, T6, T7>(
                Tuple<T1, T2, T3, T4, T5, T6, T7> tuple)
            where T1 : IAsyncCodeScopeExtension?
        {
            if (tuple == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tuple);
            }

            return new AsyncUsingExpression<T1, Tuple<T1, T2, T3, T4, T5, T6, T7>>
            {
                ScopeExtension = tuple.Item1,
                UsingVar = tuple,
            };
        }

        /// <summary>
        ///     Advanced using operator with supports <see cref="IAsyncCodeScopeExtension" /> contracts.
        /// </summary>
        /// <typeparam name="T1">The tuple item 1 type.</typeparam>
        /// <typeparam name="T2">The tuple item 2 type.</typeparam>
        /// <typeparam name="T3">The tuple item 3 type.</typeparam>
        /// <typeparam name="T4">The tuple item 4 type.</typeparam>
        /// <typeparam name="T5">The tuple item 5 type.</typeparam>
        /// <typeparam name="T6">The tuple item 6 type.</typeparam>
        /// <typeparam name="T7">The tuple item 7 type.</typeparam>
        /// <typeparam name="TRest">Any generic Tuple object that defines the types of the tuple's remaining components.</typeparam>
        /// <param name="tuple">The tuple with the disposable first item.</param>
        /// <returns>The chain syntax context.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SuppressMessage(
            "Design",
            "CA1062:Validate arguments of public methods",
            Justification = "The argument has been validated.")]
        public static AsyncUsingExpression<T1, Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>> UsingAsync<T1, T2, T3, T4, T5,
            T6, T7, TRest>(
            Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple)
            where T1 : IAsyncCodeScopeExtension?
        {
            if (tuple == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.tuple);
            }

            return new AsyncUsingExpression<T1, Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>>
            {
                ScopeExtension = tuple.Item1,
                UsingVar = tuple,
            };
        }
    }
}
