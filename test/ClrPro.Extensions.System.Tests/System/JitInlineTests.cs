// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Threading;
    using Xunit;

    public class JitInlineTests
    {
        private Counter _tst = default;

        [Fact]
        public void Test()
        {
            Debugger.Break();
            if (_tst.Flags == 5)
            {
                _tst.TestInterlockedInline();
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct Counter
        {
            private long _state;

            public long Flags => _state & 0xFF;

            public void TestInterlockedInline()
            {
                Interlocked.Increment(ref _state);
            }
        }
    }
}
