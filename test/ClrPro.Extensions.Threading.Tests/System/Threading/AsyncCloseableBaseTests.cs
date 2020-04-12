// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using System.Threading.Atomics;
    using System.Threading.Tasks;
    using ClrPro;
    using Xunit;

    public class AsyncCloseableBaseTests
    {
        [Fact]
        public async Task SimpleTest()
        {
#pragma warning disable CA2000 // Dispose objects before losing scope
            var dummyCloseable = new DummyCloseable();
#pragma warning restore CA2000 // Dispose objects before losing scope

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
            var task = ESharp.UsingAsync(dummyCloseable).DoAsync(
                async () => { });
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously

#pragma warning disable 4014
            Task.Run(
                async () =>
                {
                    await Task.Delay(100).ConfigureAwait(false);
                    dummyCloseable.StopAllPendingOperations();
                });
#pragma warning restore 4014
            await task.ConfigureAwait(false);
        }

        private class DummyCloseable : AsyncCloseableBase<RefCountingAsyncCloseableBaseState,
            LockAtomic<RefCountingAsyncCloseableBaseState>>
        {
            public DummyCloseable()
                : base(new LockAtomic<RefCountingAsyncCloseableBaseState>(new object()))
            {
                // Increasing references count.
                var state = atomicState.Read();
                state.AddRef();
                atomicState.Write(state);
            }

            public void StopAllPendingOperations()
            {
                var observedState = atomicState.Read();

                RefCountingAsyncCloseableBaseState nextState;
                bool switchedToClosingState;
                do
                {
                    switchedToClosingState = false;
                    nextState = observedState;
                    if (nextState.AreOperationsPending())
                    {
                        switchedToClosingState = nextState.ReleaseRef();
                    }
                }
                while (atomicState.CompareExchangeStrong(nextState, ref observedState));

                if (switchedToClosingState)
                {
                    NotifyPendingOperationsCompleted();
                }
            }

            protected override async ValueTask CloseAsync(Exception? terminateReason)
            {
                try
                {
                    await Task.Delay(100).ConfigureAwait(false);
                }
                finally
                {
                    OnCloseCompleted();
                }
            }
        }
    }
}
