// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Atomics
{
    using JetBrains.Annotations;

    /// <summary>
    ///     The atomic storage for the value of type <see typeparamref="T" />.
    /// </summary>
    /// <remarks>
    ///     This is polyfill implementation of the proposal <see href="https://github.com/dotnet/runtime/issues/17975" />.
    ///     This API is planned to .Net Core 5.0.
    /// </remarks>
    /// <typeparam name="T">The type of a value to store.</typeparam>
    [PublicAPI]
    public interface IAtomic<T>
    {
        /// <summary>
        ///     Reads the value atomically.
        /// </summary>
        /// <returns>The observed value.</returns>
        T Read();

        /// <summary>
        ///     Writes the provided value to the storage atomically.
        /// </summary>
        /// <param name="value">The value to write atomically to the storage.</param>
        void Write(T value);

        /// <summary>
        ///     Exchanges the storage with the provided value atomically.
        /// </summary>
        /// <param name="value">The value to write to the storage.</param>
        /// <returns>The value that was in the storage before the operation.</returns>
        T Exchange(T value);

        /// <summary>
        ///     Compares the current value in the storage with the <paramref name="comparand" /> for equality, if
        ///     they are equal, replaces the value in the storage, otherwise updates the <paramref name="comparand" /> with the
        ///     stored value.
        /// </summary>
        /// <param name="value">The value to update to.</param>
        /// <param name="comparand">On input the value to compare, on output the current value of the storage.</param>
        /// <returns>
        ///     <see langword="true" /> if the storage was updated with the <paramref name="value" />,
        ///     <see langword="false" /> otherwise.
        /// </returns>
        bool CompareExchangeStrong(T value, ref T comparand);
    }
}
