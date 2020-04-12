// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using System.Diagnostics.CodeAnalysis;

    internal static class ThrowHelper
    {
        [DoesNotReturn]
        public static void ThrowArgumentNullException(ExceptionArgument argument)
        {
            throw new ArgumentNullException(argument.ToString());
        }

        [DoesNotReturn]
        public static void ThrowInvalidOperationException()
        {
            throw new InvalidOperationException();
        }
    }
}
