// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.Extensions.BusinessDomain
{
    using System;
    using System.ObjectModel;
    using JetBrains.Annotations;

    /// <summary>
    ///     The business domain aggregate root (forbidding external objects from holding references to its members).
    /// </summary>
    /// <typeparam name="TKey">The type of the aggregate root key.</typeparam>
    /// <remarks>
    ///     <para>The DDD approach is described here <see href="https://en.wikipedia.org/wiki/Domain-driven_design" />.</para>
    /// </remarks>
    [PublicAPI]
    public interface IAggregateRoot<out TKey> : IAggregateRoot, IKeyed<TKey>
        where TKey : IEquatable<TKey>
    {
    }
}
