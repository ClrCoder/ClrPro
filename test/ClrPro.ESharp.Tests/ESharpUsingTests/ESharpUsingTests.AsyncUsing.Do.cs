// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.ESharpLang.Tests
{
    using System;
    using System.Threading.Tasks;
    using FluentAssertions;
    using Xunit;

    public partial class ESharpUsingTests
    {
        [Fact]
        public async Task AsyncUsingSyncDoTest()
        {
            #region No-Pass scope

            // Normal flow
            var dummy = new DummyAsyncCodeScopeExtension();
            await ESharp.UsingAsync(dummy)
                .Do(() => { });
            dummy.TerminateReasonException.Should().BeNull();

            // Exceptional flow
            ESharp.Y(
                () =>
                {
                    dummy = new DummyAsyncCodeScopeExtension();
                    ESharp.UsingAsync(dummy)
                        .DoAsync(() => throw new InvalidOperationException("Dummy exception."))
                        .AsTask()
                        .GetAwaiter()
                        .GetResult();
                }).Should().Throw<InvalidOperationException>();
            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion

            #region Pass scope

            dummy = new DummyAsyncCodeScopeExtension();
            await ESharp.UsingAsync(dummy)
                .Do(d => { d.Should().Be(dummy); });

            dummy.TerminateReasonException.Should().BeNull();

            ESharp.Y(
                () =>
                {
                    dummy = new DummyAsyncCodeScopeExtension();
                    ESharp.UsingAsync(dummy).DoAsync(
                            d =>
                            {
                                d.Should().Be(dummy);
                                throw new InvalidOperationException("Dummy exception.");
                            })
                        .AsTask()
                        .GetAwaiter()
                        .GetResult();
                }).Should().Throw<InvalidOperationException>();
            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion
        }
    }
}
