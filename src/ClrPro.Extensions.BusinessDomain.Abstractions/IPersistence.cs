// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.Extensions.BusinessDomain
{
    using System.Diagnostics.CodeAnalysis;
    using JetBrains.Annotations;

    /// <summary>
    ///     The persistence part that allows to build <see typeparamref="TUowBound" /> domain accessor in
    ///     the <see cref="IUnitOfWork" /> boundary.
    /// </summary>
    /// <typeparam name="TUowBound">The type of the unit of work bound domain accessor.</typeparam>
    /// <remarks>
    ///     <para>Should be resolved from the IoC and passed to the <see cref="IUnitOfWorkFactory{TServiceRestriction}" />.</para>
    ///     <para>The DDD approach is described here <see href="https://en.wikipedia.org/wiki/Domain-driven_design" />.</para>
    ///     <para>
    ///         Even if currently there is no any reason for this interface, it should be introduced as an extension point.
    ///         C# 8.0 DIM allows to extend already deployed interface.
    ///     </para>
    /// </remarks>
    [SuppressMessage(
        "Design",
        "CA1040:Avoid empty interfaces",
        Justification = "The type represent the information by itself.")]
    [SuppressMessage("ReSharper", "UnusedTypeParameter", Justification = "Reviwed")]
    [PublicAPI]
    public interface IPersistence<TUowBound>
        where TUowBound : IUnitOfWorkBound
    {
    }
}
