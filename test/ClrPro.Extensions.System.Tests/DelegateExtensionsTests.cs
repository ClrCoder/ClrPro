// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.Extensions.System.Tests
{
    using FluentAssertions;
    using global::System;
    using Xunit;
    using Xunit.Abstractions;
    using static ESharp;

    public class DelegateExtensionsTests
    {
        // ReSharper disable once NotAccessedField.Local
        private readonly ITestOutputHelper _testOutput;

        public DelegateExtensionsTests(ITestOutputHelper testOutput)
        {
            _testOutput = testOutput;
        }

        [Fact]
        public void InvokeAllTest()
        {
            var callCount = 0;
            var someException1 = Y(
                () =>
                {
                    callCount++;
                    throw new ObjectDisposedException("test");
                });
            var noExceptionAction = Y(
                () =>
                {
                    callCount++;

                    // ReSharper disable once RedundantJumpStatement
                    return;
                });
            var someException2 = Y(
                () =>
                {
                    callCount++;
                    throw new InvalidOperationException("Hello world!!!");
                });

            var multicastDelegate = someException1 + noExceptionAction + someException2;
            try
            {
                multicastDelegate.InvokeAll();
            }
            catch (AggregateException ex)
            {
                ex.InnerExceptions.Count.Should().Be(2);
                ex.InnerExceptions[0].Should().BeOfType<ObjectDisposedException>();
                ex.InnerExceptions[1].Should().BeOfType<InvalidOperationException>();
            }

            callCount.Should().Be(3);

            // Should not throw any exception. Just no-op.
            ((EventHandler?)null).InvokeAll(null, EventArgs.Empty);
        }
    }
}
