// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.ObjectModel
{
    using JetBrains.Annotations;

    /// <summary>
    ///     The object which have a key.
    /// </summary>
    /// <typeparam name="T">The type of the key.</typeparam>
    [PublicAPI]
    public interface IKeyed<out T>
        where T : IEquatable<T>
    {
        /// <summary>
        ///     The key value.
        /// </summary>
        T Id { get; }
    }
}
