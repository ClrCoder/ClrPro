// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics.CodeAnalysis;
    using JetBrains.Annotations;

    /// <summary>
    ///     Extension methods related to the <see cref="ICloseable" /> and <see cref="IAsyncCloseable" /> classes.
    /// </summary>
    [PublicAPI]
    public static class ClosableExtensions
    {
        /// <summary>
        ///     Verifies that the object is not in <see cref="ClosingStatus.Alive" /> state, throws
        ///     <see cref="ExplicitCloseMissingException" /> otherwise.
        /// </summary>
        /// <param name="closeable">The object whose state to check.</param>
        /// <exception cref="ExplicitCloseMissingException">The object wasn't explicitly closed.</exception>
        [SuppressMessage(
            "Design",
            "CA1062:Validate arguments of public methods",
            Justification = "The argument has been validated.")]
        public static void VerifyCloseRequested(this IClosingStatusObservable closeable)
        {
            if (closeable == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.closeable);
            }

            if (closeable.ClosingStatus == ClosingStatus.Alive)
            {
                ThrowHelper.ThrowExplicitCloseMissingException(closeable);
            }
        }
    }
}
