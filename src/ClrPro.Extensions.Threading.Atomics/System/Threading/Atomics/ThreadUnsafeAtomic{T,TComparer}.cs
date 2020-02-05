// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Atomics
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     The implementation of the <see cref="IAtomic{T}" /> which have no any synchronization.
    /// </summary>
    /// <typeparam name="T">The type of a value to store.</typeparam>
    /// <typeparam name="TComparer">The type of the equality comparer.</typeparam>
    [PublicAPI]
    [SuppressMessage(
        "Performance",
        "CA1815:Override equals and operator equals on value types",
        Justification = "This is very special struct type, should not be used on stack.")]
    public struct ThreadUnsafeAtomic<T, TComparer> : IAtomic<T>
        where TComparer : struct, IEqualityComparer<T>
    {
        // ReSharper disable once RedundantDefaultMemberInitializer
        private static readonly TComparer Comparer = default;
        private T _value;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ThreadUnsafeAtomic{T, TComparer}" /> struct.
        /// </summary>
        /// <param name="value">The initial value.</param>
        public ThreadUnsafeAtomic(T value)
        {
            _value = value;
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Read()
        {
            return _value;
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(T value)
        {
            _value = value;
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Exchange(T value)
        {
            var oldValue = _value;
            _value = value;
            return oldValue;
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool CompareExchangeStrong(T value, ref T comparand)
        {
            if (Comparer.Equals(_value, comparand))
            {
                _value = value;
                return true;
            }

            comparand = value;
            return false;
        }
    }
}
