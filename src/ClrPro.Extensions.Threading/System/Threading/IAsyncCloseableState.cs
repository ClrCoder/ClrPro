// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using JetBrains.Annotations;

    /// <summary>
    ///     The <see cref="IAsyncCloseable" /> state.
    /// </summary>
    [PublicAPI]
    public interface IAsyncCloseableState
    {
        /// <summary>
        ///     The current status of the object.
        /// </summary>
        ClosingStatus Status { get; }

        /// <summary>
        ///     Gets where the object started closing with exception or not.
        /// </summary>
        bool WasTerminated { get; }

        /// <summary>
        ///     Switches state to the "close requested" state.
        /// </summary>
        /// <param name="isTerminating">
        ///     <see langword="true" /> if close requested with the termination, <see langword="false" />
        ///     otherwise.
        /// </param>
        void AcceptCloseRequest(bool isTerminating);

        /// <summary>
        ///     Shows that currently some operations are pending and the object cannot be closed.
        /// </summary>
        /// <returns><see langword="true" /> if some operations are pending, <see langword="false" /> otherwise.</returns>
        bool AreOperationsPending();
    }
}
