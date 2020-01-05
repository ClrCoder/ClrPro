// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using JetBrains.Annotations;

    /// <summary>
    ///     State of a <see cref="ICloseable" /> or a <see cref="IAsyncCloseable" /> object.
    /// </summary>
    [PublicAPI]
    public enum ClosingStatus
    {
        /// <summary>
        ///     Object is alive.
        /// </summary>
        Alive,

        /// <summary>
        ///     Status where close was requested but close procedure not yet started due to pending operations.
        /// </summary>
        CloseRequested,

        /// <summary>
        ///     Close operation is in-progress.
        /// </summary>
        Closing,

        /// <summary>
        ///     Object close operation finished.
        /// </summary>
        Closed,
    }
}
