// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.ESharpLang.Tests
{
    using System;
    using FluentAssertions;
    using Xunit;

    public partial class ESharpUsingTests
    {
        [Fact]
        public void SyncUsingEvalTest()
        {
            #region No-Pass scope

            var dummy = new DummyCodeScopeExtension();

            // ReSharper disable once AccessToModifiedClosure
            var intRes = ESharp.Using(dummy).Eval(
                d =>
                {
                    d.Should().Be(dummy);
                    return 10;
                });
            intRes.Should().Be(10);
            dummy.TerminateReasonException.Should().BeNull();

            string? strRes = null;
            ESharp.Y(
                () =>
                {
                    dummy = new DummyCodeScopeExtension();
                    strRes = ESharp.Using(dummy).Eval(
                        () =>
                        {
                            // ReSharper disable once ConvertToLambdaExpression
                            throw new InvalidOperationException("Dummy exception.");
#pragma warning disable 162
                            return "Hello !";
#pragma warning restore 162
                        });
                }).Should().Throw<InvalidOperationException>();

            strRes.Should().Be(null);
            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion

            #region Pass scope

            dummy = new DummyCodeScopeExtension();

            // ReSharper disable once AccessToModifiedClosure
            intRes = ESharp.Using(dummy).Eval(
                d =>
                {
                    d.Should().Be(dummy);
                    return 11;
                });
            intRes.Should().Be(11);
            dummy.TerminateReasonException.Should().BeNull();

            strRes = null;
            ESharp.Y(
                () =>
                {
                    dummy = new DummyCodeScopeExtension();
                    strRes = ESharp.Using(dummy).Eval(
                        d =>
                        {
                            d.Should().Be(dummy);

                            // ReSharper disable once ConvertToLambdaExpression
                            throw new InvalidOperationException("Dummy exception.");

#pragma warning disable 162
                            return "Hello !!!";
#pragma warning restore 162
                        });
                }).Should().Throw<InvalidOperationException>();

            strRes.Should().BeNull();
            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion
        }
    }
}
