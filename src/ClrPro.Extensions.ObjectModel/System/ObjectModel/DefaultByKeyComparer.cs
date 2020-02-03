// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.ObjectModel
{
    using System.Collections.Generic;
    using JetBrains.Annotations;

    /// <summary>
    ///     Default comparer implementation for the <see cref="IKeyed{TKey}" /> implementation.
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TKeyed">The type of the <see cref="IKeyed{TKey}" /> implementation.</typeparam>
    [PublicAPI]
    public sealed class DefaultByKeyComparer<TKey, TKeyed> : IEqualityComparer<TKeyed>
        where TKeyed : IKeyed<TKey>
        where TKey : IEquatable<TKey>
    {
        private DefaultByKeyComparer()
        {
        }

        internal static DefaultByKeyComparer<TKey, TKeyed> Instance { get; } =
            new DefaultByKeyComparer<TKey, TKeyed>();

        /// <inheritdoc />
        public bool Equals(TKeyed x, TKeyed y)
        {
            if (x == null && y == null)
            {
                return true;
            }

            if ((x == null) ^ (y == null))
            {
                return false;
            }

            return x!.Id.Equals(y!.Id);
        }

        /// <inheritdoc />
        public int GetHashCode(TKeyed obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
