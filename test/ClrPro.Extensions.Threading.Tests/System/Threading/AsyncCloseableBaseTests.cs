// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using System.Diagnostics;
    using System.Threading.Atomics;
    using System.Threading.Tasks;
    using ClrPro;
    using Xunit;

    public class AsyncCloseableBaseTests
    {
        [Fact]
        public async Task SimpleTest()
        {
            var dummyCloseable = new DummyCloseable();
            var task = ESharp.UsingAsync(dummyCloseable).DoAsync(
                async () => { }
            );

#pragma warning disable 4014
            Task.Run(
                async () =>
                {
                    await Task.Delay(100).ConfigureAwait(false);
                    dummyCloseable.StopAllPendingOperations();
                });
#pragma warning restore 4014
            await task;
        }

        private struct DummyCloseableState : IAsyncCloseableState, IEquatable<DummyCloseableState>
        {
            public DummyCloseableState(bool operationsPending)
            {
                Status = default;
                WasTerminated = default;
                OperationsPending = operationsPending;
            }

            public ClosingStatus Status { get; private set; }

            public bool WasTerminated { get; private set; }

            public bool OperationsPending { get; private set; }

            public static bool operator ==(DummyCloseableState left, DummyCloseableState right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(DummyCloseableState left, DummyCloseableState right)
            {
                return !left.Equals(right);
            }

            public bool Equals(DummyCloseableState other)
            {
                return Status == other.Status && WasTerminated == other.WasTerminated &&
                       OperationsPending == other.OperationsPending;
            }

            public void AcceptCloseRequest(bool isTerminating)
            {
                if (OperationsPending)
                {
                    Status = ClosingStatus.CloseRequested;
                }
                else
                {
                    Status = ClosingStatus.Closing;
                }

                WasTerminated = isTerminating;
            }

            public bool AreOperationsPending()
            {
                return OperationsPending;
            }

            public void SwitchToPendingOperationsFinished()
            {
                Debug.Assert(OperationsPending, "Our logic of the component accept only one call to this method.");
                OperationsPending = false;
                if (Status == ClosingStatus.CloseRequested)
                {
                    Status = ClosingStatus.Closing;
                }
            }

            public override bool Equals(object? obj)
            {
                return obj is DummyCloseableState other && Equals(other);
            }

            public override int GetHashCode()
            {
                // Hashcode is useless for this structure.
                return 0;
            }
        }

        private class DummyCloseable : AsyncCloseableBase<DummyCloseableState, LockAtomic<DummyCloseableState>>
        {
            public DummyCloseable()
                : base(new LockAtomic<DummyCloseableState>(new object(), new DummyCloseableState(true)))
            {
            }

            public void StopAllPendingOperations()
            {
                var observedState = atomicState.Read();

                DummyCloseableState nextState;
                do
                {
                    nextState = observedState;
                    if (observedState.Status != ClosingStatus.Alive)
                    {
                        break;
                    }

                    nextState.SwitchToPendingOperationsFinished();
                }
                while (atomicState.CompareExchangeStrong(nextState, ref observedState));

                NotifyPendingOperationsCompleted();
            }

            protected override async ValueTask CloseAsync(Exception? terminateReason)
            {
                await Task.Delay(100).ConfigureAwait(false);
            }
        }
    }
}
