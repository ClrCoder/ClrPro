// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;

    internal static class ThrowHelper
    {
        [DoesNotReturn]
        public static void ThrowInvalidOperationException(ExceptionMessage message)
        {
            throw new InvalidOperationException(GetExceptionMessageText(message));
        }

        public static string GetExceptionMessageText(ExceptionMessage message)
        {
            Debug.Assert(
                Enum.IsDefined(typeof(ExceptionMessage), message),
                "The enum value is not defined, please check the ExceptionArgument Enum.");

            switch (message)
            {
                case ExceptionMessage.OnCloseCompletedShouldBeCalledInClosingState:
                    return
                        "OnCloseCompleted should be called in the 'Closing' state at the end of the closing operation.";
            }

            throw new NotSupportedException();
        }
    }
}
