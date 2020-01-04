// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.Extensions.System.Tests
{
    using FluentAssertions;
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.ExceptionServices;
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
