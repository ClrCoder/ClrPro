// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage(
        "StyleCop.CSharp.NamingRules",
        "SA1300:Element should begin with upper-case letter",
        Justification = "Reviewed")]
    [SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Reviewed")]
    internal enum ExceptionArgument
    {
        action,
        completionSource,
    }
}
