// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    /// <summary>
    ///     <see cref="Box{T}" /> related helpers.
    /// </summary>
    public static class Box
    {
        /// <summary>
        ///     Unbox Box&lt;T&gt;? construction.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="box">The boxed value.</param>
        /// <returns>The unboxed value.</returns>
        public static T Unbox<T>(this in Box<T>? box)
        {
            return box!.Value.BoxValue;
        }
    }
}
