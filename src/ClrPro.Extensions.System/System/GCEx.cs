// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     GC and memory allocation extended API.
    /// </summary>
    [PublicAPI]
    [SuppressMessage("ReSharper", "InconsistentNaming", Justification = "<anything>Ex convention.")]
    public static class GCEx
    {
        /// <summary>
        ///     Checks that passed by reference structure is 64bit aligned in memory.
        /// </summary>
        /// <typeparam name="T">The type of the struct value.</typeparam>
        /// <param name="value">The reference to the struct to check alignment of.</param>
        /// <returns><see langword="true" /> if struct native memory address is 64 bit aligned, <see langword="false" /> otherwise.</returns>
        public static unsafe bool Is64BitAligned<T>(ref T value)
            where T : struct
        {
            var address = (uint)Unsafe.AsPointer(ref value);
            return (address & 0x7UL) == 0;
        }

        /// <summary>
        ///     Checks that passed by reference structure is 128bit aligned in memory.
        /// </summary>
        /// <typeparam name="T">The type of the struct value.</typeparam>
        /// <param name="value">The reference to the struct to check alignment of.</param>
        /// <returns><see langword="true" /> if struct native memory address is 64 bit aligned, <see langword="false" /> otherwise.</returns>
        public static unsafe bool Is128BitAligned<T>(ref T value)
            where T : struct
        {
            var address = (uint)Unsafe.AsPointer(ref value);
            return (address & 0xFUL) == 0;
        }

        /// <summary>
        ///     Checks that passed by reference structure is 32bit aligned in memory.
        /// </summary>
        /// <typeparam name="T">The type of the struct value.</typeparam>
        /// <param name="value">The reference to the struct to check alignment of.</param>
        /// <returns><see langword="true" /> if struct native memory address is 64 bit aligned, <see langword="false" /> otherwise.</returns>
        public static unsafe bool Is32BitAligned<T>(ref T value)
            where T : struct
        {
            var address = (uint)Unsafe.AsPointer(ref value);
            return (address & 0x3UL) == 0;
        }
    }
}
