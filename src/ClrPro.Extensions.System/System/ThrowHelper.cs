// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;

    internal static class ThrowHelper
    {
        [DoesNotReturn]
        public static void ThrowArgumentNullException(ExceptionArgument argument)
        {
            throw new ArgumentNullException(GetArgumentName(argument));
        }

        [DoesNotReturn]
        public static void ThrowAggregateException(IEnumerable<Exception> exceptions)
        {
            throw new AggregateException(exceptions);
        }

        [DoesNotReturn]
        public static void ThrowUnhandledException(Exception innerException)
        {
            throw new UnhandledException(innerException);
        }

        private static string GetArgumentName(ExceptionArgument argument)
        {
            Debug.Assert(
                Enum.IsDefined(typeof(ExceptionArgument), argument),
                "The enum value is not defined, please check the ExceptionArgument Enum.");

            return argument.ToString();
        }
    }
}
