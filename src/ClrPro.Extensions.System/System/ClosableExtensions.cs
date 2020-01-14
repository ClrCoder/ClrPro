// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
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
        public static void VerifyCloseRequested(this INotifyClosing closeable)
        {
            if (closeable == null)
            {
                throw new ArgumentNullException(nameof(closeable));
            }

            if (closeable.ClosingStatus == ClosingStatus.Alive)
            {
                throw new ExplicitCloseMissingException(closeable);
            }
        }

        /// <summary>
        ///     Verifies that the object is not in "alive" state, throws <see cref="ExplicitCloseMissingException" /> otherwise.
        /// </summary>
        /// <param name="asyncCloseable">The object whose state to check.</param>
        /// <exception cref="ExplicitCloseMissingException">The object wasn't explicitly closed.</exception>
        public static void VerifyCloseRequested(this IAsyncNotifyClosing asyncCloseable)
        {
            if (asyncCloseable == null)
            {
                throw new ArgumentNullException(nameof(asyncCloseable));
            }

            if (asyncCloseable.ClosingStatus == ClosingStatus.Alive)
            {
                throw new ExplicitCloseMissingException(asyncCloseable);
            }
        }
    }
}
