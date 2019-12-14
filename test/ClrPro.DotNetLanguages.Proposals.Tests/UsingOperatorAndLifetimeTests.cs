using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace ClrPro.DotNetLanguages.Proposals.Tests
{
    public class UsingOperatorAndLifetimeTests
    {
        private class DummyLifetimeTerminable : ILifetimeTerminable
        {
            public Exception? TerminateReasonException { get; private set; }

            public void Dispose()
            {
            }

            public void Terminate(Exception ex)
            {
                TerminateReasonException = ex;
            }
        }

        private class AsyncDummyLifetimeTerminable : IAsyncLifetimeTerminable
        {
            public Exception? TerminateReasonException { get; private set; }

#pragma warning disable 1998
            public async ValueTask DisposeAsync()
#pragma warning restore 1998
            {
            }

#pragma warning disable 1998
            public async ValueTask TerminateAsync(Exception reasonException)
#pragma warning restore 1998
            {
                TerminateReasonException = reasonException;
            }
        }

        [Fact]
        public async Task AsyncUsingPolyfillShouldWork()
        {
            // No exception case
            var dummyTerminable = new AsyncDummyLifetimeTerminable();
#pragma warning disable 1998
            await dummyTerminable.UsingAsync(async x => { });
#pragma warning restore 1998
            dummyTerminable.TerminateReasonException.Should().BeNull("No any exception was thrown");


            // Exception case
            dummyTerminable = new AsyncDummyLifetimeTerminable();

            try
            {
#pragma warning disable 1998
                await dummyTerminable.UsingAsync(async x =>
#pragma warning restore 1998
                {
                    // ReSharper disable once NotAccessedVariable
                    var tst = 1;
                    tst /= 0;
                });
            }
            catch (DivideByZeroException ex)
            {
                dummyTerminable.TerminateReasonException.Should().BeEquivalentTo(ex);
            }
        }

        [Fact]
        public async Task UsingAsyncLifetimeExplicitShouldCompile()
        {
#pragma warning disable 219
            await using (IAsyncLifetimeExplicit? _ = default)
#pragma warning restore 219
            {
            }
        }

        [Fact(Skip = "Not yet supported by the C# compiler, see https://github.com/dotnet/roslyn/issues/40353")]
        public void UsingLifetimeExplicitShouldCompile()
        {
////#pragma warning disable 219
////            using (ILifetimeExplicit _ = default)
////#pragma warning restore 219
////            {
////            }
        }

        [Fact]
        public void UsingPolyfillShouldWork()
        {
            // No exception case
            var dummyTerminable = new DummyLifetimeTerminable();
            dummyTerminable.Using(x => { });
            dummyTerminable.TerminateReasonException.Should().BeNull("No any exception was thrown");


            // Exception case
            dummyTerminable = new DummyLifetimeTerminable();

            try
            {
                dummyTerminable.Using(x =>
                {
                    // ReSharper disable once NotAccessedVariable
                    var tst = 1;
                    tst /= 0;
                });
            }
            catch (DivideByZeroException ex)
            {
                dummyTerminable.TerminateReasonException.Should().BeEquivalentTo(ex);
            }
        }
    }
}