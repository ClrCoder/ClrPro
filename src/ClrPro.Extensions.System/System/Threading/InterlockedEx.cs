// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     Extended <see cref="Interlocked" /> API.
    /// </summary>
    [PublicAPI]
    public static class InterlockedEx
    {
        /// <summary>
        ///     Compares two double-precision floating point numbers for equality and, if they are equal, replaces the first
        ///     value.
        /// </summary>
        /// <param name="location1">
        ///     The destination, whose value is compared with <paramref name="comparand" /> and possibly
        ///     replaced.
        /// </param>
        /// <param name="value">The value that replaces the destination value if the comparison results in equality.</param>
        /// <param name="comparand">
        ///     The value that is compared to the value at <paramref name="location1" /> and receive the value
        ///     of the <paramref name="location1" /> at the moment of comparision.
        /// </param>
        /// <returns><see langword="true" />, if the exchange was performed, <see langword="false" /> otherwise.</returns>
        /// <exception cref="NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe bool CompareExchange(ref double location1, double value, ref double comparand)
        {
            var comparandLocal = comparand;
            comparand = Interlocked.CompareExchange(ref location1, value, comparandLocal);

            return comparandLocal.Equals(comparand);
        }

        /// <summary>Compares two 32-bit signed integers for equality and, if they are equal, replaces the first value.</summary>
        /// <param name="location1">
        ///     The destination, whose value is compared with <paramref name="comparand" /> and possibly
        ///     replaced.
        /// </param>
        /// <param name="value">The value that replaces the destination value if the comparison results in equality.</param>
        /// <param name="comparand">
        ///     The value that is compared to the value at <paramref name="location1" /> and receive the value
        ///     of the <paramref name="location1" /> at the moment of comparision.
        /// </param>
        /// <returns><see langword="true" />, if the exchange was performed, <see langword="false" /> otherwise.</returns>
        /// <exception cref="NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool CompareExchange(ref int location1, int value, ref int comparand)
        {
            var comparandLocal = comparand;
            comparand = Interlocked.CompareExchange(ref location1, value, comparandLocal);
            return comparandLocal == comparand;
        }

        /// <summary>
        ///     Compares two platform-specific handles or pointers for equality and, if they are equal, replaces the first
        ///     one.
        /// </summary>
        /// <param name="location1">
        ///     The destination <see cref="IntPtr" />, whose value is compared with the value of
        ///     <paramref name="comparand" /> and possibly replaced by <paramref name="value" />.
        /// </param>
        /// <param name="value">
        ///     The <see cref="IntPtr" /> that replaces the destination value if the comparison results in
        ///     equality.
        /// </param>
        /// <param name="comparand">
        ///     The <see cref="IntPtr" /> that is compared to the value at
        ///     <paramref name="location1" /> and receive the value of the <paramref name="location1" /> at the moment of
        ///     comparision.
        /// </param>
        /// <returns><see langword="true" />, if the exchange was performed, <see langword="false" /> otherwise.</returns>
        /// <exception cref="NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool CompareExchange(
            ref IntPtr location1,
            IntPtr value,
            ref IntPtr comparand)
        {
            var comparandLocal = comparand;
            comparand = Interlocked.CompareExchange(ref location1, value, comparandLocal);
            return comparandLocal == comparand;
        }

        /// <summary>
        ///     Compares two 64-bit signed integers for equality and, if they are equal, replaces the first value.
        /// </summary>
        /// <param name="location1">
        ///     The destination, whose value is compared with <paramref name="comparand" /> and possibly
        ///     replaced.
        /// </param>
        /// <param name="value">The value that replaces the destination value if the comparison results in equality.</param>
        /// <param name="comparand">
        ///     The value that is compared to the value at <paramref name="location1" /> and receive the value
        ///     of the <paramref name="location1" /> at the moment of comparision.
        /// </param>
        /// <returns><see langword="true" />, if the exchange was performed, <see langword="false" /> otherwise.</returns>
        /// <exception cref="NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool CompareExchange(ref long location1, long @value, ref long comparand)
        {
            var comparandLocal = comparand;
            comparand = Interlocked.CompareExchange(ref location1, value, comparandLocal);
            return comparandLocal == comparand;
        }

        /// <summary>
        ///     Compares two objects for reference equality and, if they are equal, replaces the first object.
        /// </summary>
        /// <param name="location1">
        ///     The destination object that is compared by reference with <paramref name="comparand" /> and
        ///     possibly replaced.
        /// </param>
        /// <param name="value">The value that replaces the destination value if the comparison results in equality.</param>
        /// <param name="comparand">
        ///     The value that is compared to the value at <paramref name="location1" /> and receive the value
        ///     of the <paramref name="location1" /> at the moment of comparision.
        /// </param>
        /// <returns><see langword="true" />, if the exchange was performed, <see langword="false" /> otherwise.</returns>
        /// <exception cref="NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool CompareExchange(ref object location1, object value, ref object comparand)
        {
            var comparandLocal = comparand;

            ////Unsafe.Write(Unsafe.AsPointer(ref comparand),
            ////    Interlocked.CompareExchange(
            ////        ref Unsafe.AsRef<long>(Unsafe.AsPointer(ref location1)),
            ////        Unsafe.As<object, long>(ref value),
            ////        Unsafe.As<object, long>(ref comparand)));

            comparand = Interlocked.CompareExchange(ref location1, value, comparandLocal);
            return ReferenceEquals(comparandLocal, comparand);
        }

        /// <summary>
        ///     Compares two single-precision floating point numbers for equality and, if they are equal, replaces the first
        ///     value.
        /// </summary>
        /// <param name="location1">
        ///     The destination object that is compared by reference with <paramref name="comparand" /> and
        ///     possibly replaced.
        /// </param>
        /// <param name="value">The value that replaces the destination value if the comparison results in equality.</param>
        /// <param name="comparand">
        ///     The value that is compared to the value at <paramref name="location1" /> and receive the value
        ///     of the <paramref name="location1" /> at the moment of comparision.
        /// </param>
        /// <returns><see langword="true" />, if the exchange was performed, <see langword="false" /> otherwise.</returns>
        /// <exception cref="NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool CompareExchange(ref float location1, float value, ref float comparand)
        {
            var comparandLocal = comparand;
            comparand = Interlocked.CompareExchange(ref location1, value, comparandLocal);
            return comparandLocal.Equals(comparand);
        }

        /// <summary>
        ///     Compares two instances of the specified reference type <typeparamref name="T" /> for reference equality and, if
        ///     they are equal, replaces the first one.
        /// </summary>
        /// <typeparam name="T">
        ///     The type to be used for <paramref name="location1" />, <paramref name="value" />, and
        ///     <paramref name="comparand" />. This type must be a reference type.
        /// </typeparam>
        /// <param name="location1">
        ///     The destination, whose value is compared by reference with <paramref name="comparand" /> and
        ///     possibly replaced. This is a reference parameter (<see langword="ref" /> in C#, <see langword="ByRef" /> in Visual
        ///     Basic).
        /// </param>
        /// <param name="value">The value that replaces the destination value if the comparison results in equality.</param>
        /// <param name="comparand">
        ///     The value that is compared to the value at <paramref name="location1" /> and receive the value
        ///     of the <paramref name="location1" /> at the moment of comparision.
        /// </param>
        /// <returns><see langword="true" />, if the exchange was performed, <see langword="false" /> otherwise.</returns>
        /// <exception cref="NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool CompareExchange<T>(ref T location1, T @value, ref T comparand)
            where T : class
        {
            var comparandLocal = comparand;
            comparand = Interlocked.CompareExchange(ref location1, value, comparandLocal);
            return ReferenceEquals(comparandLocal, comparand);
        }
    }
}
