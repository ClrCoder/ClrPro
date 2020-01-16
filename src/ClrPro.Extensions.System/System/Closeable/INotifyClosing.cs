// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using JetBrains.Annotations;

    /// <summary>
    ///     Notifies about object closing.
    /// </summary>
    /// <remarks>
    ///     Implementation should always go through all states of an object
    ///     <see cref="System.ClosingStatus.CloseRequested" />,
    ///     <see cref="System.ClosingStatus.Closing" />, <see cref="System.ClosingStatus.Closed" />.
    /// </remarks>
    [PublicAPI]
    public interface INotifyClosing : IClosingStatusObservable
    {
        /// <summary>
        ///     Raised when the object switched to <see cref="System.ClosingStatus.CloseRequested" /> state.
        /// </summary>
        event EventHandler CloseRequested;

        /// <summary>
        ///     Raised when the object switched to <see cref="System.ClosingStatus.Closing" /> state.
        /// </summary>
        event EventHandler Closing;

        /// <summary>
        ///     Raised when the object switched to <see cref="System.ClosingStatus.Closed" /> state.
        /// </summary>
        event EventHandler Closed;
    }
}
