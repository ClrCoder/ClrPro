// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    /// <content>
    ///     <see cref="YT" /> methods implementation.
    /// </content>
    [SuppressMessage(
        "ReSharper",
        "InconsistentNaming",
        Justification = "YA, Y it's not a regular method, but language extension.")]
    public static partial class ESharp
    {
        /// <summary>
        ///     Converts async lambda/anonymous method definition to the delegate value. (Y ≡ λ - lambda).
        /// </summary>
        /// <param name="asyncAction">The delegate value that are produced by the language from the lambda expression.</param>
        /// <returns>The delegate value from the input <paramref name="asyncAction" />.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Func<Task> YT(Func<Task> asyncAction)
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
        public static Func<T, Task> YT<T>(Func<T, Task> asyncAction)
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
        public static Func<T1, T2, Task> YT<T1, T2>(Func<T1, T2, Task> asyncAction)
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
        public static Func<T1, T2, T3, Task> YT<T1, T2, T3>(Func<T1, T2, T3, Task> asyncAction)
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
        public static Func<T1, T2, T3, T4, Task> YT<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> asyncAction)
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
        public static Func<T1, T2, T3, T4, T5, Task> YT<T1, T2, T3, T4, T5>(
            Func<T1, T2, T3, T4, T5, Task> asyncAction)
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
        public static Func<T1, T2, T3, T4, T5, T6, Task> YT<T1, T2, T3, T4, T5, T6>(
            Func<T1, T2, T3, T4, T5, T6, Task> asyncAction)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, Task> YT<T1, T2, T3, T4, T5, T6, T7>(
            Func<T1, T2, T3, T4, T5, T6, T7, Task> asyncAction)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> YT<T1, T2, T3, T4, T5, T6, T7, T8>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> asyncAction)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> YT<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> asyncAction)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> YT<T1, T2, T3, T4, T5, T6, T7, T8, T9,
            T10>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> asyncAction)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> YT<T1, T2, T3, T4, T5, T6, T7, T8,
            T9, T10, T11>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> asyncAction)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> YT<T1, T2, T3, T4, T5, T6, T7,
            T8, T9, T10, T11, T12>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> asyncAction)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> YT<T1, T2, T3, T4, T5, T6,
            T7, T8, T9, T10, T11, T12, T13>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> asyncAction)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> YT<T1, T2, T3, T4, T5,
            T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> asyncAction)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> YT<T1, T2, T3,
            T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> asyncAction)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> YT<T1, T2,
            T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> asyncAction)
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
        public static Func<Task<TResult>> YT<TResult>(Func<Task<TResult>> func)
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
        public static Func<T, Task<TResult>> YT<T, TResult>(Func<T, Task<TResult>> func)
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
        public static Func<T1, T2, Task<TResult>> YT<T1, T2, TResult>(Func<T1, T2, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, Task<TResult>> YT<T1, T2, T3, TResult>(
            Func<T1, T2, T3, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, T4, Task<TResult>> YT<T1, T2, T3, T4, TResult>(
            Func<T1, T2, T3, T4, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, T4, T5, Task<TResult>> YT<T1, T2, T3, T4, T5, TResult>(
            Func<T1, T2, T3, T4, T5, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, T4, T5, T6, Task<TResult>> YT<T1, T2, T3, T4, T5, T6, TResult>(
            Func<T1, T2, T3, T4, T5, T6, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> YT<T1, T2, T3, T4, T5, T6, T7, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> YT<T1, T2, T3, T4, T5, T6, T7, T8,
            TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> YT<T1, T2, T3, T4, T5, T6, T7, T8,
            T9,
            TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> YT<T1, T2, T3, T4, T5, T6, T7,
            T8, T9, T10, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> YT<T1, T2, T3, T4, T5, T6,
            T7, T8, T9, T10, T11, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> YT<T1, T2, T3, T4, T5,
            T6, T7, T8, T9, T10, T11, T12, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> YT<T1, T2, T3,
            T4,
            T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> YT<T1, T2,
            T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> YT<T1,
            T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> asyncFunc)
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>>
            YT<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
                Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>>
                    asyncFunc)
        {
            return asyncFunc;
        }
    }
}
