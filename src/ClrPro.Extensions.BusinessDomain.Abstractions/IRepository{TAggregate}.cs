// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.Extensions.BusinessDomain
{
    using System.Diagnostics.CodeAnalysis;
    using JetBrains.Annotations;

    /// <summary>
    ///     The repository for the aggregate <typeparamref name="TAggregate" />.
    /// </summary>
    /// <typeparam name="TAggregate">The type of the aggregate.</typeparam>
    /// <remarks>
    ///     <para>The DDD approach is described here <see href="https://en.wikipedia.org/wiki/Domain-driven_design" />.</para>
    ///     <para>
    ///         Even if currently there is no any reason for this interface, it should be introduced as an extension point.
    ///         C# 8.0 DIM allows to extend already deployed interface.
    ///     </para>
    /// </remarks>
    [SuppressMessage("Design", "CA1040:Avoid empty interfaces", Justification = "Reviewed")]
    [SuppressMessage("ReSharper", "UnusedTypeParameter", Justification = "Reviewed")]
    [PublicAPI]
    public interface IRepository<TAggregate>
        where TAggregate : IAggregateRoot
    {
    }
}
