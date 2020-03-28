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
    [PublicAPI]
    public interface IUnitOfWorkFactory
    {
        /// <summary>
        ///     Creates unit of work with the specified domain accessors.
        /// </summary>
        /// <typeparam name="T1">The type of the domain accessor 1.</typeparam>
        /// <param name="persistence1">The persistence provider 1.</param>
        /// <param name="commitOnClose">
        ///     <see langword="true" /> sets <see cref="IUnitOfWork.CloseAction" /> to <see cref="UowCloseAction.Commit" />,
        ///     <see langword="false" /> will sets <see cref="IUnitOfWork.CloseAction" /> to <see cref="UowCloseAction.Rollback" />
        ///     .
        /// </param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The tuple with the <see cref="IUnitOfWork" /> and domain accessors.</returns>
        ValueTask<Tuple<IUnitOfWork, T1>> OpenAsync<T1>(
            IPersistence<T1> persistence1,
            bool commitOnClose = true,
            CancellationToken cancellationToken = default)
            where T1 : IUnitOfWorkBound;

        /// <summary>
        ///     Creates unit of work with the specified domain accessors.
        /// </summary>
        /// <typeparam name="T1">The type of the domain accessor 1.</typeparam>
        /// <typeparam name="T2">The type of the domain accessor 2.</typeparam>
        /// <param name="persistence1">The persistence provider 1.</param>
        /// <param name="persistence2">The persistence provider 2.</param>
        /// <param name="commitOnClose">
        ///     <see langword="true" /> sets <see cref="IUnitOfWork.CloseAction" /> to <see cref="UowCloseAction.Commit" />,
        ///     <see langword="false" /> will sets <see cref="IUnitOfWork.CloseAction" /> to <see cref="UowCloseAction.Rollback" />
        ///     .
        /// </param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The tuple with the <see cref="IUnitOfWork" /> and domain accessors.</returns>
        ValueTask<Tuple<IUnitOfWork, T1, T2>> OpenAsync<T1, T2>(
            IPersistence<T1> persistence1,
            IPersistence<T2> persistence2,
            bool commitOnClose = true,
            CancellationToken cancellationToken = default)
            where T1 : IUnitOfWorkBound
            where T2 : IUnitOfWorkBound;
    }
}
