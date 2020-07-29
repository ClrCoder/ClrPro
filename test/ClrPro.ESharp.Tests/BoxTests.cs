// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.ESharpLang.Tests
{
    using System;
    using FluentAssertions;
    using Xunit;

    public class BoxTests
    {
        [Fact]
        public void ValueTypeTests()
        {
            Box<int> a = 5, b = 5, c = 6;
            Box<int>? a1 = 5, b1 = 5, c1 = 6, d1 = null, e1 = null;
            Box<Box<int>?>? a2 = (Box<int>)5, b2 = (Box<int>)5;
            Box<Box<int>?>? innerNull = (Box<int>?)null;
            Box<int?>? simpleInnerNull = (Box<int?>)null;
            Box<int?>? plainNull = null;
            (a == b).Should().BeTrue();
            (a == c).Should().BeFalse();
            (a1 == b1).Should().BeTrue();
            (a1 == c1).Should().BeFalse();
            (a1 == d1).Should().BeFalse();
            (d1 == e1).Should().BeTrue();
            (a2 == b2).Should().BeTrue();
            (innerNull == null).Should().BeFalse();
            (innerNull != null).Should().BeTrue();
            (innerNull!.Value == null).Should().BeTrue();
            (simpleInnerNull == plainNull).Should().BeFalse();
        }
    }
}
