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
        public async Task AsyncUsingAsyncEvalTest()
        {
            #region No-Pass scope

            // Normal flow
            var dummy = new DummyAsyncCodeScopeExtension();
            var intRes = await ESharp.UsingAsync(dummy)
                .EvalAsync(
                    async () =>
                    {
                        await Task.Delay(10);
                        return 10;
                    });
            intRes.Should().Be(10);
            dummy.TerminateReasonException.Should().BeNull();

            string? strRes = null;

            // Exceptional flow
            ESharp.Y(
                () =>
                {
                    dummy = new DummyAsyncCodeScopeExtension();
                    strRes = ESharp.UsingAsync(dummy)
                        .EvalAsync(
                            async () =>
                            {
                                await Task.Delay(10);
                                throw new InvalidOperationException("Dummy exception.");

#pragma warning disable 162
                                return "Hello!";
#pragma warning restore 162
                            })
                        .AsTask()
                        .GetAwaiter()
                        .GetResult();
                }).Should().Throw<InvalidOperationException>();

            strRes.Should().Be(null);
            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion

            #region Pass scope

            dummy = new DummyAsyncCodeScopeExtension();
            intRes = await ESharp.UsingAsync(dummy)
                .EvalAsync(
                    async d =>
                    {
                        await Task.Delay(10);
                        d.Should().Be(dummy);
                        return 12;
                    });

            intRes.Should().Be(12);
            dummy.TerminateReasonException.Should().BeNull();

            strRes = null;
            ESharp.Y(
                () =>
                {
                    dummy = new DummyAsyncCodeScopeExtension();
                    strRes = ESharp.UsingAsync(dummy).EvalAsync(
                            async d =>
                            {
                                await Task.Delay(10);
                                d.Should().Be(dummy);
                                throw new InvalidOperationException("Dummy exception.");
#pragma warning disable 162
                                return "Hello !!!";
#pragma warning restore 162
                            })
                        .AsTask()
                        .GetAwaiter()
                        .GetResult();
                }).Should().Throw<InvalidOperationException>();

            strRes.Should().Be(null);
            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion
        }

        [Fact]
        public async Task AsyncUsingTaskEvalTest()
        {
            #region No-Pass scope

            // Normal flow
            var dummy = new DummyAsyncCodeScopeExtension();
            var intRes = await ESharp.UsingAsync(dummy)
                .EvalTAsync(
                    async () =>
                    {
                        await Task.Delay(10);
                        return 10;
                    });
            intRes.Should().Be(10);
            dummy.TerminateReasonException.Should().BeNull();

            string? strRes = null;

            // Exceptional flow
            ESharp.Y(
                () =>
                {
                    dummy = new DummyAsyncCodeScopeExtension();
                    strRes = ESharp.UsingAsync(dummy)
                        .EvalTAsync(
                            async () =>
                            {
                                await Task.Delay(10);
                                throw new InvalidOperationException("Dummy exception.");

#pragma warning disable 162
                                return "Hello!";
#pragma warning restore 162
                            })
                        .AsTask()
                        .GetAwaiter()
                        .GetResult();
                }).Should().Throw<InvalidOperationException>();

            strRes.Should().Be(null);
            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion

            #region Pass scope

            dummy = new DummyAsyncCodeScopeExtension();
            intRes = await ESharp.UsingAsync(dummy)
                .EvalTAsync(
                    async d =>
                    {
                        await Task.Delay(10);
                        d.Should().Be(dummy);
                        return 12;
                    });

            intRes.Should().Be(12);
            dummy.TerminateReasonException.Should().BeNull();

            strRes = null;
            ESharp.Y(
                () =>
                {
                    dummy = new DummyAsyncCodeScopeExtension();
                    strRes = ESharp.UsingAsync(dummy).EvalTAsync(
                            async d =>
                            {
                                await Task.Delay(10);
                                d.Should().Be(dummy);
                                throw new InvalidOperationException("Dummy exception.");
#pragma warning disable 162
                                return "Hello !!!";
#pragma warning restore 162
                            })
                        .AsTask()
                        .GetAwaiter()
                        .GetResult();
                }).Should().Throw<InvalidOperationException>();

            strRes.Should().Be(null);
            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion
        }
    }
}
