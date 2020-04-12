// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.Extensions.BusinessDomain
{
    using JetBrains.Annotations;

    /// <summary>
    ///     The scheduled action on regular close of a <see cref="IUnitOfWork" />.
    /// </summary>
    [PublicAPI]
    public enum UowCloseAction
    {
        /// <summary>
        ///     Commit changes on close.
        /// </summary>
        Commit = default,

        /// <summary>
        ///     Rollback canes on close.
        /// </summary>
        Rollback,

        /// <summary>
        ///     Release resources on close, commit operation already performed.
        /// </summary>
        Release,
    }
}
