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
    public struct SpinLockAtomic<T> : IAtomic<T>
        where T : IEquatable<T>
    {
        private SpinLock _guard;
        private T _value;

        /// <summary>
        ///     Initializes a new instance of the <see cref="SpinLockAtomic{T}" /> struct.
        /// </summary>
        /// <param name="value">The initial value.</param>
        /// <param name="enableThreadOwnerTracking">
        ///     Whether to capture and use thread IDs for debugging
        ///     purposes.
        /// </param>
        public SpinLockAtomic(T value, bool enableThreadOwnerTracking)
        {
            _value = value;
            _guard = new SpinLock(enableThreadOwnerTracking);
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Read()
        {
            var lockTaken = false;

            _guard.Enter(ref lockTaken);

            var observedValue = _value;

            if (lockTaken)
            {
                _guard.Exit();
            }

            return observedValue;
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(T value)
        {
            var lockTaken = false;
            _guard.Enter(ref lockTaken);

            _value = value;
            if (lockTaken)
            {
                _guard.Exit(true);
            }
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Exchange(T value)
        {
            var lockTaken = false;
            _guard.Enter(ref lockTaken);

            var observedValue = _value;
            _value = value;

            if (lockTaken)
            {
                _guard.Exit(true);
            }

            return observedValue;
        }

        /// <inheritdoc />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool CompareExchangeStrong(T value, ref T comparand)
        {
            var lockTaken = false;
            _guard.Enter(ref lockTaken);

            if ((_value == null && comparand == null) || (_value != null && _value.Equals(comparand)))
            {
                _value = value;
                if (lockTaken)
                {
                    _guard.Exit(true);
                }

                return true;
            }

            comparand = value;

            if (lockTaken)
            {
                _guard.Exit();
            }

            return false;
        }
    }
}
