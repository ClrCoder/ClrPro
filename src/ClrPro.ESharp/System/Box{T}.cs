// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using JetBrains.Annotations;

    /// <summary>
    ///     Makes any value to be wrapped as value type. It's designed to be used in the Box&lt;T&gt;? construction.
    /// </summary>
    /// <typeparam name="T">The value to be stored in the box.</typeparam>
    [Serializable]
    [PublicAPI]
    public readonly struct Box<T> : IEquatable<Box<T>>
    {
        private readonly T _value;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Box{T}" /> struct.
        /// </summary>
        /// <param name="value">The box content.</param>
        private Box(T value)
        {
            _value = value;
        }

        /// <summary>
        ///     The value of the box.
        /// </summary>
        /// <remarks>
        ///     Use <see cref="Box.Unbox{T}" />.
        /// </remarks>
        public T BoxValue => _value;

        /// <summary>
        ///     Implicitly converts value to a boxed value.
        /// </summary>
        /// <param name="value">The value to cover into a box.</param>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "Reviewed.")]
        public static implicit operator Box<T>(T value)
        {
            return new Box<T>(value);
        }

        /// <summary>
        ///     Implicitly converts box to value.
        /// </summary>
        /// <param name="box">The box to convert.</param>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "Reviewed.")]
        public static implicit operator T(Box<T> box)
        {
            return box._value;
        }

        /// <summary>
        ///     Checks if the operands are equals.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns><see langword="true" /> if the operands are equals, <see langword="false" /> otherwise.</returns>
        public static bool operator ==(Box<T> left, Box<T> right)
        {
            return left.Equals(right);
        }

        /// <summary>
        ///     Checks if the operands are not equals.
        /// </summary>
        /// <param name="left">The left operand.</param>
        /// <param name="right">The right operand.</param>
        /// <returns><see langword="true" /> if the operands are not equals, <see langword="false" /> otherwise.</returns>
        public static bool operator !=(Box<T> left, Box<T> right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        public bool Equals(Box<T> other)
        {
            return EqualityComparer<T>.Default.Equals(_value, other._value);
        }

        /// <inheritdoc />
        public override bool Equals(object? other)
        {
            return other switch
            {
                null => false,
                Box<T> otherBox => EqualityComparer<T>.Default.Equals(_value, otherBox._value),
                _ => false,
            };
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return _value?.GetHashCode() ?? 0;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return _value?.ToString() ?? string.Empty;
        }
    }
}
