using System;
using System.Runtime.CompilerServices;
using FluentAssertions;
using Xunit;
using static ClrPro.Extensions.CompilerServices.ESharp;

namespace ClrPro.Extensions.CompilerServices.Tests
{
    public class ExtendedUsingOperatorTests
    {
        private class DummyCodeScopeExtension : ICodeScopeExtension
        {
            public Exception? TerminateReasonException { get; private set; }

            public void OnLoseCodeScope(Exception? exception)
            {
                TerminateReasonException = exception;
            }
        }

        [Fact]
        public void SyncUsingShouldWorks()
        {
            Using(out var dummy, new DummyCodeScopeExtension()).Do(() => { });
            dummy.TerminateReasonException.Should().BeNull();


            try
            {
                Using(out dummy, new DummyCodeScopeExtension()).Do(() => { throw new InvalidOperationException("Dummy exception."); });
            }
            catch
            {
                // Do nothing.
            }

            dummy.TerminateReasonException.Should().BeOfType<InvalidOperationException>();
        }
    }
}