// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.Extensions.BusinessDomain
{
    using System;
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>
    ///     The unit of work.
    /// </summary>
    [PublicAPI]
    public interface IUnitOfWork : IAsyncTerminable
    {
        /// <summary>
        ///     Explicitly commits the current unit of work changes.
        /// </summary>
        /// <remarks>
        ///     Explicit call to the <see cref="Commit" /> load back from the persistence the new values of entities which was
        ///     updated during the commit phase.
        /// </remarks>
        /// <param name="update">
        ///     <see langword="true" /> if the UoW loaded entities should be updated from the persistence after
        ///     the commit, <see langword="false" /> otherwise.
        /// </param>
        /// <returns>The async execution task.</returns>
        ValueTask Commit(bool update = false);

        /// <summary>
        ///     Rollbacks the current unit of work changes.
        /// </summary>
        /// <returns>The async execution task.</returns>
        ValueTask Rollback();
    }
}
