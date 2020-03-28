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
        ///     The scheduled action on close of the UoW.
        /// </summary>
        UowCloseAction CloseAction { get; }

        /// <summary>
        ///     Sets up commit action on close of the UoW.
        /// </summary>
        void CommitOnClose();

        /// <summary>
        ///     Sets up rollback action on close of the UoW.
        /// </summary>
        void RollbackOnClose();

        /// <summary>
        ///     Explicitly commits the current unit of work changes.
        /// </summary>
        /// <remarks>
        ///     Explicit call to the <see cref="Commit" /> load back from the persistence the new values of entities which was
        ///     updated during the commit phase.
        /// </remarks>
        /// <returns>The async execution task.</returns>
        ValueTask Commit();
    }
}
