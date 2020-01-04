// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    // ReSharper disable InconsistentNaming

    /// <content>
    ///     <see cref="YA" /> methods implementation.
    /// </content>
    public static partial class ESharp
    {
        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<ValueTask> YA(Func<ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T">The type of the parameter of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T, ValueTask> YA<T>(Func<T, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, ValueTask> YA<T1, T2>(Func<T1, T2, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, ValueTask> YA<T1, T2, T3>(Func<T1, T2, T3, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, ValueTask> YA<T1, T2, T3, T4>(Func<T1, T2, T3, T4, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, ValueTask> YA<T1, T2, T3, T4, T5>(
            Func<T1, T2, T3, T4, T5, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, ValueTask> YA<T1, T2, T3, T4, T5, T6>(
            Func<T1, T2, T3, T4, T5, T6, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, ValueTask> YA<T1, T2, T3, T4, T5, T6, T7>(
            Func<T1, T2, T3, T4, T5, T6, T7, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, ValueTask> YA<T1, T2, T3, T4, T5, T6, T7, T8>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ValueTask> YA<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ValueTask> YA<T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the parameter 11 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ValueTask> YA<T1, T2, T3, T4, T5, T6, T7, T8,
            T9, T10, T11>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the parameter 11 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the parameter 12 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ValueTask> YA<T1, T2, T3, T4, T5, T6, T7,
            T8, T9, T10, T11, T12>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the parameter 11 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the parameter 12 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the parameter 13 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ValueTask> YA<T1, T2, T3, T4, T5, T6,
            T7, T8, T9, T10, T11, T12, T13>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the parameter 11 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the parameter 12 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the parameter 13 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the parameter 14 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ValueTask> YA<T1, T2, T3, T4,
            T5,
            T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the parameter 11 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the parameter 12 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the parameter 13 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the parameter 14 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the parameter 15 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ValueTask> YA<T1, T2, T3,
            T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the parameter 11 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the parameter 12 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the parameter 13 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the parameter 14 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the parameter 15 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the parameter 16 of the method that this delegate encapsulates.</typeparam>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ValueTask> YA<T1, T2,
            T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ValueTask> asyncAction)
        {
            return asyncAction;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<ValueTask<TResult>> YA<TResult>(Func<ValueTask<TResult>> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T">The type of the parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T, ValueTask<TResult>> YA<T, TResult>(Func<T, ValueTask<TResult>> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, ValueTask<TResult>> YA<T1, T2, TResult>(Func<T1, T2, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, ValueTask<TResult>> YA<T1, T2, T3, TResult>(
            Func<T1, T2, T3, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, ValueTask<TResult>> YA<T1, T2, T3, T4, TResult>(
            Func<T1, T2, T3, T4, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, ValueTask<TResult>> YA<T1, T2, T3, T4, T5, TResult>(
            Func<T1, T2, T3, T4, T5, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, ValueTask<TResult>> YA<T1, T2, T3, T4, T5, T6, TResult>(
            Func<T1, T2, T3, T4, T5, T6, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, ValueTask<TResult>> YA<T1, T2, T3, T4, T5, T6, T7, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, ValueTask<TResult>> YA<T1, T2, T3, T4, T5, T6, T7, T8,
            TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ValueTask<TResult>> YA<T1, T2, T3, T4, T5, T6, T7, T8,
            T9,
            TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ValueTask<TResult>> YA<T1, T2, T3, T4, T5, T6, T7,
            T8, T9, T10, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the parameter 11 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ValueTask<TResult>> YA<T1, T2, T3, T4, T5, T6,
            T7, T8, T9, T10, T11, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the parameter 11 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the parameter 12 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ValueTask<TResult>> YA<T1, T2, T3, T4, T5,
            T6, T7, T8, T9, T10, T11, T12, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the parameter 11 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the parameter 12 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the parameter 13 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ValueTask<TResult>> YA<T1, T2, T3,
            T4,
            T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the parameter 11 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the parameter 12 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the parameter 13 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the parameter 14 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ValueTask<TResult>> YA<T1, T2,
            T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the parameter 11 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the parameter 12 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the parameter 13 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the parameter 14 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the parameter 15 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ValueTask<TResult>> YA<T1,
            T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ValueTask<TResult>> asyncFunc)
        {
            return asyncFunc;
        }

        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T9">The type of the parameter 9 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T10">The type of the parameter 10 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T11">The type of the parameter 11 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T12">The type of the parameter 12 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T13">The type of the parameter 13 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T14">The type of the parameter 14 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T15">The type of the parameter 15 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T16">The type of the parameter 16 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="asyncFunc">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncFunc" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ValueTask<TResult>>
            YA<
                T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ValueTask<TResult>>
                    asyncFunc)
        {
            return asyncFunc;
        }
    }
}
