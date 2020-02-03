// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.Extensions.BusinessDomain
{
    using System.Diagnostics.CodeAnalysis;
    using JetBrains.Annotations;

    /// <summary>
    ///     The unit of work bound domain accessor (for example <see cref="IRepository" /> or domain service).
    /// </summary>
    /// <remarks>
    ///     <para>The DDD approach is described here <see href="https://en.wikipedia.org/wiki/Domain-driven_design" />.</para>
    ///     <para>
    ///         Even if currently there is no any reason for this interface, it should be introduced as an extension point.
    ///         C# 8.0 DIM allows to extend already deployed interface.
    ///     </para>
    /// </remarks>
    [SuppressMessage("Design", "CA1040:Avoid empty interfaces", Justification = "Emphasizes DDD implementation idea.")]
    [PublicAPI]
    public interface IUnitOfWorkBound
    {
    }
}
