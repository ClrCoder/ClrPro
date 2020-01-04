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
        public async Task AsyncUsingAsyncDoTest()
        {
            #region No-Pass scope

            // Normal flow
            var dummy = new DummyAsyncCodeScopeExtension();
            await ESharp.UsingAsync(dummy)
                .DoAsync(async () => { await Task.Delay(10); });
            dummy.TerminateReasonException.Should().BeNull();

            // Exceptional flow
            ESharp.Y(
                () =>
                {
                    dummy = new DummyAsyncCodeScopeExtension();
                    ESharp.UsingAsync(dummy)
                        .DoAsync(
                            async () =>
                            {
                                await Task.Delay(10);
                                throw new InvalidOperationException("Dummy exception.");
                            })
                        .GetAwaiter()
                        .GetResult();
                }).Should().Throw<InvalidOperationException>();
            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion

            #region Pass scope

            dummy = new DummyAsyncCodeScopeExtension();
            await ESharp.UsingAsync(dummy)
                .DoAsync(
                    async d =>
                    {
                        await Task.Delay(10);
                        d.Should().Be(dummy);
                    });

            dummy.TerminateReasonException.Should().BeNull();

            ESharp.Y(
                () =>
                {
                    dummy = new DummyAsyncCodeScopeExtension();
                    ESharp.UsingAsync(dummy).DoAsync(
                        async d =>
                        {
                            await Task.Delay(10);
                            d.Should().Be(dummy);
                            throw new InvalidOperationException("Dummy exception.");
                        }).GetAwaiter().GetResult();
                }).Should().Throw<InvalidOperationException>();
            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion
        }

        [Fact]
        public async Task AsyncUsingDoTaskTest()
        {
            #region No-Pass scope

            // Normal flow
            var dummy = new DummyAsyncCodeScopeExtension();
            await ESharp.UsingAsync(dummy)
                .DoTAsync(async () => { await Task.Delay(10); });
            dummy.TerminateReasonException.Should().BeNull();

            // Exceptional flow
            ESharp.Y(
                () =>
                {
                    dummy = new DummyAsyncCodeScopeExtension();
                    ESharp.UsingAsync(dummy)
                        .DoTAsync(
                            async () =>
                            {
                                await Task.Delay(10);
                                throw new InvalidOperationException("Dummy exception.");
                            })
                        .GetAwaiter()
                        .GetResult();
                }).Should().Throw<InvalidOperationException>();
            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion

            #region Pass scope

            dummy = new DummyAsyncCodeScopeExtension();
            await ESharp.UsingAsync(dummy)
                .DoTAsync(
                    async d =>
                    {
                        await Task.Delay(10);
                        d.Should().Be(dummy);
                    });

            dummy.TerminateReasonException.Should().BeNull();

            ESharp.Y(
                () =>
                {
                    dummy = new DummyAsyncCodeScopeExtension();
                    ESharp.UsingAsync(dummy).DoTAsync(
                        async d =>
                        {
                            await Task.Delay(10);
                            d.Should().Be(dummy);
                            throw new InvalidOperationException("Dummy exception.");
                        }).GetAwaiter().GetResult();
                }).Should().Throw<InvalidOperationException>();
            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion
        }
    }
}
