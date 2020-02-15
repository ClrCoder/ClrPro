// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Tasks.Sources
{
    using System.Diagnostics.CodeAnalysis;
    using JetBrains.Annotations;

    /// <summary>
    ///     Ready to use wrapper for the <see cref="ManualResetValueTaskSourceCore{TResult}" />.
    /// </summary>
    [PublicAPI]
    [SuppressMessage(
        "Design",
        "CA1033:Interface methods should be callable by child types",
        Justification = "Reviewed")]
    public sealed class CompletionSourceSlim : IValueTaskSource, ITaskCompletionSource
    {
        // ReSharper disable once RedundantDefaultMemberInitializer
        private ManualResetValueTaskSourceCore2<byte> _core = default;

        /// <summary>
        ///     The task that will completes when the <see cref="SetCompletionResult" /> called.
        /// </summary>
        public ValueTask Task => new ValueTask(this, _core.Version);

        /// <inheritdoc />
        void IValueTaskSource.GetResult(short token)
        {
            _core.GetResult(token);
        }

        /// <inheritdoc />
        ValueTaskSourceStatus IValueTaskSource.GetStatus(short token)
        {
            return _core.GetStatus(token);
        }

        /// <inheritdoc />
        void IValueTaskSource.OnCompleted(
            Action<object?> continuation,
            object state,
            short token,
            ValueTaskSourceOnCompletedFlags flags)
        {
            _core.OnCompleted(continuation, state, token, flags);
        }

        /// <inheritdoc />
        public void SetCompletionResult(TaskCompletionResult result)
        {
            if (result.IsSuccessful)
            {
                _core.SetResult(default);
            }
            else
            {
                _core.SetExceptionDispatchInfo(result.ExceptionHolder!.DispatchInfo);
            }
        }
    }
}
