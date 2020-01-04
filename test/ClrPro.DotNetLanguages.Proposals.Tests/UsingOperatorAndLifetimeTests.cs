using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using static System.Runtime.CompilerServices.UsingPolyfill;
namespace ClrPro.DotNetLanguages.Proposals.Tests
{
    public class UsingOperatorAndLifetimeTests
    {
        [Fact]
        public void UsingPolyfillShouldWork()
        {
            
            new Action(() =>
            {

            }).InvokeWith;
            
            Test.Inv
            // No exception case
            var dummyTerminable = Using(new DummyCodeScopeExtension(), _ =>
            {

            });
            dummyTerminable.TerminateReasonException.Should().BeNull("No any exception was thrown");


            // Exception case
            dummyTerminable = new DummyCodeScopeExtension();

            try
            {
                dummyTerminable = Using()
                CSharpProposalPolyfillExtensions.Using(dummyTerminable, x =>
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

        //        private class AsyncDummyLifetimeTerminable : IAsyncLifetimeTerminable
        //        {
        //            public Exception? TerminateReasonException { get; private set; }

        //#pragma warning disable 1998
        //            public async ValueTask DisposeAsync()
        //#pragma warning restore 1998
        //            {
        //            }

        //#pragma warning disable 1998
        //            public async ValueTask TerminateAsync(Exception reasonException)
        //#pragma warning restore 1998
        //            {
        //                TerminateReasonException = reasonException;
        //            }
        //        }

        //        [Fact]
        //        public async Task AsyncUsingPolyfillShouldWork()
        //        {
        //            // No exception case
        //            var dummyTerminable = new AsyncDummyLifetimeTerminable();
        //#pragma warning disable 1998
        //            await CSharpProposalPolyfillExtensions.Using(dummyTerminable, async x => { });
        //#pragma warning restore 1998
        //            dummyTerminable.TerminateReasonException.Should().BeNull("No any exception was thrown");


        //            // Exception case
        //            dummyTerminable = new AsyncDummyLifetimeTerminable();

        //            try
        //            {
        //#pragma warning disable 1998
        //                await CSharpProposalPolyfillExtensions.Using(dummyTerminable, async x =>
        //#pragma warning restore 1998
        //                {
        //                    // ReSharper disable once NotAccessedVariable
        //                    var tst = 1;
        //                    tst /= 0;
        //                });
        //            }
        //            catch (DivideByZeroException ex)
        //            {
        //                dummyTerminable.TerminateReasonException.Should().BeEquivalentTo(ex);
        //            }
        //        }

        //        [Fact]
        //        public async Task UsingAsyncLifetimeExplicitShouldCompile()
        //        {
        //#pragma warning disable 219
        //            await using (IAsyncLifetimeExplicit? _ = default)
        //#pragma warning restore 219
        //            {
        //            }
        //        }

        //        [Fact(Skip = "Not yet supported by the C# compiler, see https://github.com/dotnet/roslyn/issues/40353")]
        //        public void UsingLifetimeExplicitShouldCompile()
        //        {
        //////#pragma warning disable 219
        //////            using (ILifetimeExplicit _ = default)
        //////#pragma warning restore 219
        //////            {
        //////            }
        //        }


    }
}