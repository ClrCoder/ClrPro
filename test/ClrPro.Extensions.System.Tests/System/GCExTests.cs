// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using FluentAssertions;
    using Xunit;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Reviewed.")]
    public class GCExTests
    {
        private uint _i0;
        private uint _i1;
        private uint _i2;
        private uint _i3;
        private ushort _s0;
        private ushort _s1;

        [Fact]
        public void Is32BitAlignedTest()
        {
            GCEx.Is32BitAligned(ref _s0).Should().BeTrue();
            GCEx.Is32BitAligned(ref _s1).Should().BeFalse();
        }

        [Fact]
        public void Is64BitAlignedTest()
        {
            (GCEx.Is64BitAligned(ref _i0) ^ GCEx.Is64BitAligned(ref _i1)).Should().BeTrue();
        }

        [Fact]
        public void Is128BitAlignedTest()
        {
            (GCEx.Is128BitAligned(ref _i0) ^ GCEx.Is128BitAligned(ref _i1) ^ GCEx.Is128BitAligned(ref _i2) ^
             GCEx.Is128BitAligned(ref _i3)).Should().BeTrue();
        }
    }
}
