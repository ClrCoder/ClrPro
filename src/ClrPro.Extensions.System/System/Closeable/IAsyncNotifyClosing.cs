// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>
    ///     Notifies about object closing.
    /// </summary>
    [PublicAPI]
    public interface IAsyncNotifyClosing : IClosingStatusObservable
    {
        /// <summary>
        ///     Gets the <see cref="ValueTask" /> that becomes completed when the object switches to "close requested", "closing"
        ///     or "closed" state.
        /// </summary>
        /// <remarks>
        ///     Property getter could be called multiple times and each returned <see cref="ValueTask" /> should support
        ///     one await.
        /// </remarks>
        ValueTask CloseRequested { get; }

        /// <summary>
        ///     Gets the <see cref="ValueTask" /> that becomes completed when the object switches to "closing" or "closed" state.
        /// </summary>
        /// <remarks>
        ///     Property getter could be called multiple times and each returned <see cref="ValueTask" /> should support
        ///     one await.
        /// </remarks>
        ValueTask Closing { get; }

        /// <summary>
        ///     Gets the <see cref="ValueTask" /> that becomes completed when the object switches to "closed" state.
        /// </summary>
        /// <remarks>
        ///     Property getter could be called multiple times and each returned <see cref="ValueTask" /> should support
        ///     one await.
        /// </remarks>
        ValueTask Closed { get; }
    }
}
