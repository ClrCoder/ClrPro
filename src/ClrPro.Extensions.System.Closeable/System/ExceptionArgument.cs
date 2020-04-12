// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Special Purpose enum names")]
    [SuppressMessage(
        "StyleCop.CSharp.NamingRules",
        "SA1300:Element should begin with upper-case letter",
        Justification = "Special Purpose enum names")]
    internal enum ExceptionArgument
    {
        closeable,
    }
}
