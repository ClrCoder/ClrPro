// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using JetBrains.Annotations;

    /// <summary>
    ///     The state object contract required by <see cref="AsyncCloseableBase{TState,TAtomicState}" />.
    /// </summary>
    [PublicAPI]
    public interface IAsyncCloseableBaseState
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
        ///     Shows that object was closed by critical path. (From garbage collection).
        /// </summary>
        bool WasClosedCritical { get; }

        /// <summary>
        ///     Switches state to the "close requested" state.
        /// </summary>
        /// <param name="isTerminating">
        ///     <see langword="true" /> if close requested with the termination, <see langword="false" />
        ///     otherwise.
        /// </param>
        /// <returns>
        ///     <see langword="true" /> if the close request switched state to the Closing state (there were no operations
        ///     pending).
        /// </returns>
        bool AcceptCloseRequest(bool isTerminating);

        /// <summary>
        ///     Shows that currently some operations are pending and the object cannot be closed.
        /// </summary>
        /// <returns><see langword="true" /> if some operations are pending, <see langword="false" /> otherwise.</returns>
        bool AreOperationsPending();

        /// <summary>
        ///     Switches state from the <see cref="ClosingStatus.Closing" /> to the <see cref="ClosingStatus.Closed" />.
        /// </summary>
        void SetClosed();

        /// <summary>
        ///     Switches object state to a "Closed Critical".
        /// </summary>
        void SetClosedCritical();
    }
}
