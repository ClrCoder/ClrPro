// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.Extensions.BusinessDomain
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>
    ///     The <see cref="IUnitOfWork" /> factory.
    /// </summary>
    /// <typeparam name="TUowBoundRestriction">The type from which all unit of work bound accessors should be inherited.</typeparam>
    [PublicAPI]
    public interface IUnitOfWorkFactory<in TUowBoundRestriction>
        where TUowBoundRestriction : IUnitOfWorkBound
    {
        /// <summary>
        ///     Creates unit of work with the specified domain accessors.
        /// </summary>
        /// <typeparam name="T1">The type of the domain accessor 1.</typeparam>
        /// <param name="persistence1">The persistence provider 1.</param>
        /// <param name="autoCommit">
        ///     <see langword="true" /> to commit changes when unit of work closes and
        ///     <see cref="IUnitOfWork.Commit" /> was not called.
        /// </param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The tuple with the <see cref="IUnitOfWork" /> and domain accessors.</returns>
        ValueTask<Tuple<IUnitOfWork, T1>> OpenAsync<T1>(
            IPersistence<T1> persistence1,
            bool autoCommit = true,
            CancellationToken cancellationToken = default)
            where T1 : TUowBoundRestriction;

        /// <summary>
        ///     Creates unit of work with the specified domain accessors.
        /// </summary>
        /// <typeparam name="T1">The type of the domain accessor 1.</typeparam>
        /// <typeparam name="T2">The type of the domain accessor 2.</typeparam>
        /// <param name="persistence1">The persistence provider 1.</param>
        /// <param name="persistence2">The persistence provider 2.</param>
        /// <param name="autoCommit">
        ///     <see langword="true" /> to commit changes when unit of work closes and
        ///     <see cref="IUnitOfWork.Commit" /> was not called.
        /// </param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The tuple with the <see cref="IUnitOfWork" /> and domain accessors.</returns>
        ValueTask<Tuple<IUnitOfWork, T1, T2>> OpenAsync<T1, T2>(
            IPersistence<T1> persistence1,
            IPersistence<T2> persistence2,
            bool autoCommit = true,
            CancellationToken cancellationToken = default)
            where T1 : TUowBoundRestriction
            where T2 : TUowBoundRestriction;
    }
}
