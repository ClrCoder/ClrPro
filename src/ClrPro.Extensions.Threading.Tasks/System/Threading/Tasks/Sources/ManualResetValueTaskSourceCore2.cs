// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Tasks.Sources
{
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.ExceptionServices;
    using System.Runtime.InteropServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     Provides the core logic for implementing a manual-reset <see cref="IValueTaskSource" /> or
    ///     <see cref="IValueTaskSource{TResult}" />.
    /// </summary>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    [StructLayout(LayoutKind.Auto)]
    [PublicAPI]
    [SuppressMessage(
        "Performance",
        "CA1815:Override equals and operator equals on value types",
        Justification = "Reviewed")]
    [SuppressMessage(
        "StyleCop.CSharp.MaintainabilityRules",
        "SA1405:Debug.Assert should provide message text",
        Justification = "Reviewed")]
    [SuppressMessage(
        "StyleCop.CSharp.DocumentationRules",
        "SA1615:Element return value should be documented",
        Justification = "Reviewed")]
    public struct ManualResetValueTaskSourceCore2<TResult>
    {
        /// <summary>
        ///     TODO: Remove this shim when the https://github.com/dotnet/runtime/issues/30867 will be shipped.
        /// </summary>
        private static readonly ContextCallback InvokeContinuationAction = state =>
        {
            Debug.Assert(state != null);

            var invokeData = (InvokeData)state;

            Debug.Assert(invokeData.Continuation != null);

            switch (invokeData.CapturedContext)
            {
                case null:
                    if (invokeData.RunContinuationsAsynchronously)
                    {
                        if (invokeData.ExecutionContext != null)
                        {
                            ThreadPool.QueueUserWorkItem(invokeData.Continuation, invokeData.ContinuationState, true);
                        }
                        else
                        {
#if NETSTANDARD2_1
                            ThreadPoolShim.UnsafeQueueUserWorkItem(
                                invokeData.Continuation,
                                invokeData.ContinuationState,
                                true);
#else
                            ThreadPool.UnsafeQueueUserWorkItem(
                                invokeData.Continuation,
                                invokeData.ContinuationState,
                                true);
#endif
                        }
                    }
                    else
                    {
                        invokeData.Continuation(invokeData.ContinuationState);
                    }

                    break;

                case SynchronizationContext sc:
                    sc.Post(
                        s =>
                        {
                            var state = (Tuple<Action<object?>, object?>)s!;
                            state.Item1(state.Item2);
                        },
                        Tuple.Create(invokeData.Continuation, invokeData.ContinuationState));
                    break;

                case TaskScheduler ts:
                    Task.Factory.StartNew(
                        invokeData.Continuation,
                        invokeData.ContinuationState,
                        CancellationToken.None,
                        TaskCreationOptions.DenyChildAttach,
                        ts);
                    break;
            }
        };

        /// <summary>
        ///     The callback to invoke when the operation completes if <see cref="OnCompleted" /> was called before the operation
        ///     completed,
        ///     or <see cref="ManualResetValueTaskSourceCoreShared2.s_sentinel" /> if the operation completed before a callback was
        ///     supplied,
        ///     or null if a callback hasn't yet been provided and the operation hasn't yet completed.
        /// </summary>
        private Action<object?>? _continuation;

        /// <summary>State to pass to <see cref="_continuation" />.</summary>
        private object? _continuationState;

        /// <summary><see cref="ExecutionContext" /> to flow to the callback, or null if no flowing is required.</summary>
        private ExecutionContext? _executionContext;

        /// <summary>
        ///     A "captured" <see cref="SynchronizationContext" /> or <see cref="TaskScheduler" /> with which to invoke the
        ///     callback,
        ///     or null if no special context is required.
        /// </summary>
        private object? _capturedContext;

        /// <summary>Whether the current operation has completed.</summary>
        private bool _completed;

        /// <summary>The result with which the operation succeeded, or the default value if it hasn't yet completed or failed.</summary>
        [AllowNull]
        [MaybeNull]
        private TResult _result;

        /// <summary>The exception with which the operation failed, or null if it hasn't yet completed or completed successfully.</summary>
        private ExceptionDispatchInfo? _error;

        /// <summary>The current version of this value, used to help prevent misuse.</summary>
        private short _version;

        /// <summary>Gets or sets whether to force continuations to run asynchronously.</summary>
        /// <remarks>Continuations may run asynchronously if this is false, but they'll never run synchronously if this is true.</remarks>
        public bool RunContinuationsAsynchronously { get; set; }

        /// <summary>Gets the operation version.</summary>
        public short Version => _version;

        /// <summary>Resets to prepare for the next operation.</summary>
        public void Reset()
        {
            // Reset/update state for the next use/await of this instance.
            _version++;
            _completed = false;
            _result = default;
            _error = null;
            _executionContext = null;
            _capturedContext = null;
            _continuation = null;
            _continuationState = null;
        }

        /// <summary>Completes with a successful result.</summary>
        /// <param name="result">The result.</param>
        public void SetResult(TResult result)
        {
            _result = result;
            SignalCompletion();
        }

        /// <summary>Completes with an error.</summary>
        /// <param name="error">The exception.</param>
        public void SetException(Exception error)
        {
            _error = ExceptionDispatchInfo.Capture(error);
            SignalCompletion();
        }

        /// <summary>Completes with an error.</summary>
        /// <param name="dispatchInfo">The exception dispatch info.</param>
        public void SetExceptionDispatchInfo(ExceptionDispatchInfo dispatchInfo)
        {
            _error = dispatchInfo;
            SignalCompletion();
        }

        /// <summary>Gets the status of the operation.</summary>
        /// <param name="token">Opaque value that was provided to the <see cref="ValueTask" />'s constructor.</param>
        public ValueTaskSourceStatus GetStatus(short token)
        {
            ValidateToken(token);
            return
                _continuation == null || !_completed ? ValueTaskSourceStatus.Pending :
                _error == null ? ValueTaskSourceStatus.Succeeded :
                _error.SourceException is OperationCanceledException ? ValueTaskSourceStatus.Canceled :
                ValueTaskSourceStatus.Faulted;
        }

        /// <summary>Gets the result of the operation.</summary>
        /// <param name="token">Opaque value that was provided to the <see cref="ValueTask" />'s constructor.</param>
        public TResult GetResult(short token)
        {
            ValidateToken(token);
            if (!_completed)
            {
                ThrowHelper.ThrowInvalidOperationException();
            }

            _error?.Throw();
            return _result;
        }

        /// <summary>Schedules the continuation action for this operation.</summary>
        /// <param name="continuation">The continuation to invoke when the operation has completed.</param>
        /// <param name="state">The state object to pass to <paramref name="continuation" /> when it's invoked.</param>
        /// <param name="token">Opaque value that was provided to the <see cref="ValueTask" />'s constructor.</param>
        /// <param name="flags">The flags describing the behavior of the continuation.</param>
        public void OnCompleted(
            Action<object?> continuation,
            object? state,
            short token,
            ValueTaskSourceOnCompletedFlags flags)
        {
            if (continuation == null)
            {
                throw new ArgumentNullException(nameof(continuation));
            }

            ValidateToken(token);

            if ((flags & ValueTaskSourceOnCompletedFlags.FlowExecutionContext) != 0)
            {
                _executionContext = ExecutionContext.Capture();
            }

            if ((flags & ValueTaskSourceOnCompletedFlags.UseSchedulingContext) != 0)
            {
                var sc = SynchronizationContext.Current;
                if (sc != null && sc.GetType() != typeof(SynchronizationContext))
                {
                    _capturedContext = sc;
                }
                else
                {
                    var ts = TaskScheduler.Current;
                    if (ts != TaskScheduler.Default)
                    {
                        _capturedContext = ts;
                    }
                }
            }

            // We need to set the continuation state before we swap in the delegate, so that
            // if there's a race between this and SetResult/Exception and SetResult/Exception
            // sees the _continuation as non-null, it'll be able to invoke it with the state
            // stored here.  However, this also means that if this is used incorrectly (e.g.
            // awaited twice concurrently), _continuationState might get erroneously overwritten.
            // To minimize the chances of that, we check preemptively whether _continuation
            // is already set to something other than the completion sentinel.
            object? oldContinuation = _continuation;
            if (oldContinuation == null)
            {
                _continuationState = state;
                oldContinuation = Interlocked.CompareExchange(ref _continuation, continuation, null);
            }

            if (oldContinuation != null)
            {
                // Operation already completed, so we need to queue the supplied callback.
                if (!ReferenceEquals(oldContinuation, ManualResetValueTaskSourceCoreShared2.s_sentinel))
                {
                    ThrowHelper.ThrowInvalidOperationException();
                }

                switch (_capturedContext)
                {
                    case null:
                        if (_executionContext != null)
                        {
                            ThreadPool.QueueUserWorkItem(continuation, state, true);
                        }
                        else
                        {
#if NETSTANDARD2_1
                            // This is the most popular case.
                            ThreadPoolShim.UnsafeQueueUserWorkItem(continuation, state, true);
#else
                            // This is the most popular case.
                            ThreadPool.UnsafeQueueUserWorkItem(continuation, state, true);
#endif
                        }

                        break;

                    case SynchronizationContext sc:
                        sc.Post(
                            s =>
                            {
                                var tuple = (Tuple<Action<object?>, object?>)s!;
                                tuple.Item1(tuple.Item2);
                            },
                            Tuple.Create(continuation, state));
                        break;

                    case TaskScheduler ts:
                        Task.Factory.StartNew(
                            continuation,
                            state,
                            CancellationToken.None,
                            TaskCreationOptions.DenyChildAttach,
                            ts);
                        break;
                }
            }
        }

        /// <summary>Ensures that the specified token matches the current version.</summary>
        /// <param name="token">The token supplied by <see cref="ValueTask" />.</param>
        private void ValidateToken(short token)
        {
            if (token != _version)
            {
                ThrowHelper.ThrowInvalidOperationException();
            }
        }

        /// <summary>Signals that the operation has completed.  Invoked after the result or error has been set.</summary>
        private void SignalCompletion()
        {
            if (_completed)
            {
                ThrowHelper.ThrowInvalidOperationException();
            }

            _completed = true;

            if (_continuation != null || Interlocked.CompareExchange(
                ref _continuation,
                ManualResetValueTaskSourceCoreShared2.s_sentinel,
                null) != null)
            {
                if (_executionContext != null)
                {
                    ExecutionContext.Run(
                        _executionContext,
                        InvokeContinuationAction,
                        new InvokeData
                        {
                            Continuation = _continuation,
                            CapturedContext = _capturedContext,
                            RunContinuationsAsynchronously = RunContinuationsAsynchronously,
                            ExecutionContext = _executionContext,
                            ContinuationState = _continuationState,
                        });
                }
                else
                {
                    InvokeContinuation();
                }
            }
        }

        /// <summary>
        ///     Invokes the continuation with the appropriate captured context / scheduler.
        ///     This assumes that if <see cref="_executionContext" /> is not null we're already
        ///     running within that <see cref="ExecutionContext" />.
        /// </summary>
        private void InvokeContinuation()
        {
            // ATTENTION! Do not forget to edit also InvokeContinuationAction
            Debug.Assert(_continuation != null);

            switch (_capturedContext)
            {
                case null:
                    if (RunContinuationsAsynchronously)
                    {
                        if (_executionContext != null)
                        {
                            ThreadPool.QueueUserWorkItem(_continuation, _continuationState, true);
                        }
                        else
                        {
#if NETSTANDARD2_1
                            ThreadPoolShim.UnsafeQueueUserWorkItem(_continuation, _continuationState, true);
#else
                            ThreadPool.UnsafeQueueUserWorkItem(_continuation, _continuationState, true);
#endif
                        }
                    }
                    else
                    {
                        _continuation(_continuationState);
                    }

                    break;

                case SynchronizationContext sc:
                    sc.Post(
                        s =>
                        {
                            var state = (Tuple<Action<object?>, object?>)s!;
                            state.Item1(state.Item2);
                        },
                        Tuple.Create(_continuation, _continuationState));
                    break;

                case TaskScheduler ts:
                    Task.Factory.StartNew(
                        _continuation,
                        _continuationState,
                        CancellationToken.None,
                        TaskCreationOptions.DenyChildAttach,
                        ts);
                    break;
            }
        }

        [SuppressMessage(
            "StyleCop.CSharp.MaintainabilityRules",
            "SA1401:Fields should be private",
            Justification = "Reviewed")]
        private class InvokeData
        {
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
            public Action<object?> Continuation;
            public object? CapturedContext;
            public bool RunContinuationsAsynchronously;
            public ExecutionContext ExecutionContext;
            public object? ContinuationState;
        }
    }

    internal static class
        ManualResetValueTaskSourceCoreShared2 // separated out of generic to avoid unnecessary duplication
    {
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Reviewed")]
        [SuppressMessage(
            "StyleCop.CSharp.NamingRules",
            "SA1308:Variable names should not be prefixed",
            Justification = "Reviewed")]
        [SuppressMessage(
            "StyleCop.CSharp.NamingRules",
            "SA1307:Accessible fields should begin with upper-case letter",
            Justification = "Reviewed")]
        [SuppressMessage(
            "StyleCop.CSharp.NamingRules",
            "SA1304:Non-private readonly fields should begin with upper-case letter",
            Justification = "Reviewed")]
        [SuppressMessage(
            "StyleCop.CSharp.NamingRules",
            "SA1311:Static readonly fields should begin with upper-case letter",
            Justification = "Reviewed")]
        [SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Reviewed")]
        internal static readonly Action<object?> s_sentinel = CompletionSentinel;

        [SuppressMessage(
            "StyleCop.CSharp.NamingRules",
            "SA1313:Parameter names should begin with lower-case letter",
            Justification = "Reviewed")]
        private static void CompletionSentinel(object? _) // named method to aid debugging
        {
            Debug.Fail("The sentinel delegate should never be invoked.");

            // ReSharper disable once HeuristicUnreachableCode
            ThrowHelper.ThrowInvalidOperationException();
        }
    }
}
