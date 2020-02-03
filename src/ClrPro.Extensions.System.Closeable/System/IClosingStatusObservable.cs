// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using JetBrains.Annotations;

    /// <summary>
    ///     Allows to observe closing status.
    /// </summary>
    [PublicAPI]
    public interface IClosingStatusObservable
    {
        /// <summary>
        ///     Lifetime status of the object.
        /// </summary>
        ClosingStatus ClosingStatus { get; }
    }
}
