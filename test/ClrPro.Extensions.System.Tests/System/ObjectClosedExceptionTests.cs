// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Runtime.CompilerServices;
    using System.Runtime.ExceptionServices;
    using FluentAssertions;
    using Xunit;

    public class ObjectClosedExceptionTests
    {
        [Fact]
        public void ReThrowPreserveCallStackShouldMaintainSourceObjectReference()
        {
            try
            {
                try
                {
                    MyMethod();
                }
                catch (ObjectDisposedException ex)
                {
                    ExceptionDispatchInfo.Capture(ex).Throw();
                }
            }
            catch (ObjectClosedException ex)
            {
                ex.SourceObject.Should().Be(this);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private void MyMethod()
        {
            throw new ObjectClosedException(this);
        }
    }
}
