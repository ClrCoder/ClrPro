// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Threading.Atomics;
    using System.Threading.Tasks;
    using System.Threading.Tasks.Sources;
    using JetBrains.Annotations;

    /// <summary>
    ///     The base implementation for the <see cref="IAsyncCloseable" /> abstraction.
    /// </summary>
    /// <typeparam name="TState">The final type of the state.</typeparam>
    /// <typeparam name="TAtomic">The atomic storage implementation fro the state.</typeparam>
    [PublicAPI]
    public abstract partial class AsyncCloseableBase<TState, TAtomic> : IAsyncCloseable
        where TState : struct, IAsyncCloseableState
        where TAtomic : struct, IAtomic<TState>
    {
        /// <summary>
        ///     The atomic storage for the object state.
        /// </summary>
        [SuppressMessage(
            "Design",
            "CA1051:Do not declare visible instance fields",
            Justification = "It's an atomic storage, which should be accessible by all inheritance tree.")]
        [SuppressMessage(
            "StyleCop.CSharp.MaintainabilityRules",
            "SA1401:Fields should be private",
            Justification = "Reviewed")]
        protected TAtomic atomicState;

        private readonly CompletionSourceSlim _pendingOperationsCompleted = new CompletionSourceSlim();

        /// <summary>
        ///     Initializes a new instance of the <see cref="AsyncCloseableBase{TState, TAtomic}" /> class.
        /// </summary>
        /// <param name="atomicState">The initial state of the atomic storage.</param>
        protected AsyncCloseableBase(TAtomic atomicState)
        {
            this.atomicState = atomicState;
        }

        /// <summary>
        ///     Finalizes an instance of the <see cref="AsyncCloseableBase{TState, TAtomic}" /> class.
        /// </summary>
        ~AsyncCloseableBase()
        {
            // If the finalizer was called, than something goes wrong with the object lifecycle.
            // We needs to release critical resources to avoid leaks or deadlocks.
            DisposeCritical();
        }

        /// <inheritdoc />
        public ClosingStatus ClosingStatus => atomicState.Read().Status;

        /// <summary>
        ///     The value that returns by the <see cref="IAsyncCodeScopeExtension.IsRethrowRequired" />.
        /// </summary>
        protected bool ScopeErrorReThrowRequired { get; set; } = true;

        /// <summary>
        ///     Notifies that all pending operations were completed.
        /// </summary>
        /// <remarks>
        ///     Should be called only once after the object switched from <see cref="System.ClosingStatus.CloseRequested" /> to
        ///     <see cref="System.ClosingStatus.Closing" />.
        /// </remarks>
        protected void NotifyPendingOperationsCompleted()
        {
            Debug.Assert(
                atomicState.Read().Status == ClosingStatus.Closing,
                "Notification should be called in appropriate state.");

            var task = CloseAsync(null);

            // Subscribing continuation of the task.
            task.ContinueWith(_pendingOperationsCompleted);
        }

        /// <summary>
        ///     The async close operation. It's executed when pending completes.
        /// </summary>
        /// <param name="terminateReason">The terminate reason.</param>
        /// <returns>The async execution task.</returns>
        protected abstract ValueTask CloseAsync(Exception? terminateReason);

        /// <summary>
        ///     Tries to start closing operation.
        /// </summary>
        /// <param name="terminateReason">The terminate reason exception or <see langword="null" /> for normal close.</param>
        /// <param name="closeTask">The resulting async task, if the operation started.</param>
        /// <returns><see langword="true" /> if the operation started, <see langword="false" /> otherwise.</returns>
        [SecurityCritical]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected bool TryCloseAsync(Exception? terminateReason, out ValueTask closeTask)
        {
            var observedState = atomicState.Read();

            TState nextState;
            do
            {
                nextState = observedState;
                if (observedState.Status != ClosingStatus.Alive)
                {
                    break;
                }

                nextState.AcceptCloseRequest(terminateReason != null);
            }
            while (atomicState.CompareExchangeStrong(nextState, ref observedState));

            if (nextState.Status == ClosingStatus.Alive)
            {
                // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
                if (!nextState.AreOperationsPending())
                {
                    closeTask = CloseAsync(terminateReason);
                }
                else
                {
                    // Do nothing.
                    // Waiting for the  NotifyPendingOperationsCompleted call to stop pending and start closing.
                    closeTask = _pendingOperationsCompleted.Task;
                }
            }
            else
            {
                closeTask = default;
            }

            return nextState.Status == ClosingStatus.Alive;
        }

        /// <summary>
        ///     Disposes unmanaged resources, forcefully releases locks.
        /// </summary>
        protected virtual void DisposeCritical()
        {
        }
    }
}
