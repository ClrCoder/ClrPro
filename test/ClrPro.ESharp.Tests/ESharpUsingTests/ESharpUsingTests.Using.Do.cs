// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.ESharpLang.Tests
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using FluentAssertions;
    using JetBrains.Annotations;
    using Xunit;
    using static ESharp;

    [SuppressMessage(
        "StyleCop.CSharp.ReadabilityRules",
        "SA1123:Do not place regions within elements",
        Justification = "This is very repetitive unit tests.")]
    [NoReorder] // The order of test method is meaningful.
    [SuppressMessage(
        "StyleCop.CSharp.DocumentationRules",
        "SA1601:Partial elements should be documented",
        Justification = "It's only unit test.")]
    [SuppressMessage(
        "Reliability",
        "CA2007:Consider calling ConfigureAwait on the awaited task",
        Justification = "Tests are not using any synchronization contexts.")]
    public partial class ESharpUsingTests
    {
        [Fact]
        public void SyncUsingDoTest()
        {
            #region No-Pass scope

            var dummy = new DummyCodeScopeExtension();

            // ReSharper disable once AccessToModifiedClosure
            Using(dummy).Do(d => { d.Should().Be(dummy); });
            dummy.TerminateReasonException.Should().BeNull();

            Y(
                () =>
                {
                    dummy = new DummyCodeScopeExtension();
                    Using(dummy).Do(
                        () =>
                        {
                            // ReSharper disable once ConvertToLambdaExpression
                            throw new InvalidOperationException("Dummy exception.");
                        });
                }).Should().Throw<InvalidOperationException>();

            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion

            #region Pass scope

            dummy = new DummyCodeScopeExtension();

            // ReSharper disable once AccessToModifiedClosure
            Using(dummy).Do(d => { d.Should().Be(dummy); });
            dummy.TerminateReasonException.Should().BeNull();

            Y(
                () =>
                {
                    dummy = new DummyCodeScopeExtension();
                    Using(dummy).Do(
                        d =>
                        {
                            d.Should().Be(dummy);

                            // ReSharper disable once ConvertToLambdaExpression
                            throw new InvalidOperationException("Dummy exception.");
                        });
                }).Should().Throw<InvalidOperationException>();

            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();

            #endregion
        }

        private class DummyCodeScopeExtension : ICodeScopeExtension
        {
            public Exception? TerminateReasonException { get; private set; }

            public void OnLoseCodeScope(Exception? exception)
            {
                TerminateReasonException = exception;
            }
        }

        private class DummyAsyncCodeScopeExtension : IAsyncCodeScopeExtension
        {
            public Exception? TerminateReasonException { get; private set; }

            public async ValueTask OnLoseCodeScopeAsync(Exception? exception)
            {
                await Task.Delay(10).ConfigureAwait(false);
                TerminateReasonException = exception;
            }
        }
    }
}
