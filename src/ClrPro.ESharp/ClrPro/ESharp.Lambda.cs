// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro
{
    using System;
    using System.Runtime.CompilerServices;

    /// <content>
    ///     <see cref="Y" /> methods implementation.
    /// </content>
    public static partial class ESharp
    {
        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action Y(Action action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T">The type of the parameter of the method that this delegate encapsulates.</typeparam>
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T> Y<T>(Action<T> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2> Y<T1, T2>(Action<T1, T2> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3> Y<T1, T2, T3>(Action<T1, T2, T3> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3, T4> Y<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3, T4, T5> Y<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3, T4, T5, T6> Y<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3, T4, T5, T6, T7> Y<T1, T2, T3, T4, T5, T6, T7>(
            Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T8">The type of the parameter 8 of the method that this delegate encapsulates.</typeparam>
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8> Y<T1, T2, T3, T4, T5, T6, T7, T8>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Y<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Y<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Y<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
            T11>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Y<T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10,
            T11, T12>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Y<T1, T2, T3, T4, T5, T6, T7, T8,
            T9,
            T10, T11, T12, T13>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Y<T1, T2, T3, T4, T5, T6, T7,
            T8,
            T9,
            T10, T11, T12, T13, T14>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Y<T1, T2, T3, T4, T5, T6,
            T7,
            T8,
            T9,
            T10, T11, T12, T13, T14, T15>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="action">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="action" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Y<T1, T2, T3, T4,
            T5, T6,
            T7,
            T8,
            T9,
            T10, T11, T12, T13, T14, T15, T16>(
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            return action;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<TResult> Y<TResult>(Func<TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T">The type of the parameter of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T, TResult> Y<T, TResult>(Func<T, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, TResult> Y<T1, T2, TResult>(Func<T1, T2, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, TResult> Y<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, TResult> Y<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, TResult> Y<T1, T2, T3, T4, T5, TResult>(
            Func<T1, T2, T3, T4, T5, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, TResult> Y<T1, T2, T3, T4, T5, T6, TResult>(
            Func<T1, T2, T3, T4, T5, T6, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <typeparam name="T1">The type of the parameter 1 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T2">The type of the parameter 2 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T3">The type of the parameter 3 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T4">The type of the parameter 4 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T5">The type of the parameter 5 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T6">The type of the parameter 6 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="T7">The type of the parameter 7 of the method that this delegate encapsulates.</typeparam>
        /// <typeparam name="TResult">The type of the return value of the delegate.</typeparam>
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, TResult> Y<T1, T2, T3, T4, T5, T6, T7, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Y<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Y<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Y<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,
            TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Y<T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10, T11,
            TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Y<T1, T2, T3, T4, T5, T6, T7, T8,
            T9,
            T10, T11, T12,
            TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Y<T1, T2, T3, T4, T5, T6,
            T7, T8,
            T9,
            T10, T11, T12, T13,
            TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Y<T1, T2, T3, T4, T5,
            T6, T7, T8,
            T9,
            T10, T11, T12, T13, T14,
            TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Y<T1, T2, T3, T4,
            T5,
            T6, T7, T8,
            T9,
            T10, T11, T12, T13, T14, T15,
            TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func)
        {
            return func;
        }

        /// <summary>
        ///     Converts lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
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
        /// <param name="func">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="func" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Y<T1, T2, T3,
            T4, T5,
            T6, T7, T8,
            T9,
            T10, T11, T12, T13, T14, T15, T16,
            TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func)
        {
            return func;
        }
    }
}
