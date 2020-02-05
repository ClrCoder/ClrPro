// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Atomics
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     <see langword="lock" /> based <see cref="IAtomic{T}" /> implementation.
    /// </summary>
    /// <typeparam name="T">The type of a value to store.</typeparam>
    [PublicAPI]
    [SuppressMessage(
        "Performance",
        "CA1815:Override equals and operator equals on value types",
        Justification = "This is very special struct type, should not be used on stack.")]
    public struct LockAtomic<T> : IAtomic<T>
        where T : IEquatable<T>
    {
        private readonly object _guard;

        private T _value;

        /// <summary>
        ///     Initializes a new instance of the <see cref="LockAtomic{T}" /> struct.
        /// </summary>
        /// <param name="guard">The object used for the state synchronization.</param>
        /// <param name="value">The initial value.</param>
        public LockAtomic(object guard, T value = default)
        {
            _guard = guard;
            _value = value;
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Read()
        {
            T observed;
            lock (_guard)
            {
                observed = _value;
            }

            return observed;
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(T value)
        {
            lock (_guard)
            {
                _value = value;
            }
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Exchange(T value)
        {
            lock (_guard)
            {
                var oldValue = _value;
                _value = value;
                return oldValue;
            }
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool CompareExchangeStrong(T value, ref T comparand)
        {
            lock (_guard)
            {
                if ((_value == null && comparand == null) || (_value != null && _value.Equals(comparand)))
                {
                    _value = value;
                    return true;
                }

                comparand = value;
                return false;
            }
        }
    }
}
