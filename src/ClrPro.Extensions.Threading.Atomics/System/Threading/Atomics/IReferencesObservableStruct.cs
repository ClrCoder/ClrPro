// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Atomics
{
    using JetBrains.Annotations;

    /// <summary>
    ///     Observes all references that are stored in a struct.
    /// </summary>
    /// <remarks>
    ///     Used by the <see cref="IAtomic{T}" /> implementations to pin objects before an interlocked operation.
    /// </remarks>
    [PublicAPI]
    public interface IReferencesObservableStruct
    {
        /// <summary>
        ///     The count of stored references by the implementing <see langword="struct" />.
        /// </summary>
        int Count { get; }

        /// <summary>
        ///     Returns the references that are stored in the implementing <see langword="struct" />.
        /// </summary>
        /// <param name="index">The index of the reference to get.</param>
        /// <returns>The stored reference.</returns>
        object? this[int index] { get; }
    }
}
