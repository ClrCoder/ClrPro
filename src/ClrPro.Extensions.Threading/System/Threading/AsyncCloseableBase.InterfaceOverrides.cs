// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

// ReSharper disable UnusedTypeParameter

namespace System.Threading
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    /// <content>
    ///     Interfaces full override.
    /// </content>
    [SuppressMessage(
        "StyleCop.CSharp.ReadabilityRules",
        "SA1124:Do not use regions",
        Justification = "Sometimes it's usefull.")]
    [SuppressMessage(
        "Design",
        "CA1033:Interface methods should be callable by child types",
        Justification = "Finally we have method to override in inheritors.")]
    public abstract partial class AsyncCloseableBase<TState, TAtomic>
    {
#pragma warning disable SA1201 // Elements should appear in the correct order

        #region IAsyncCodeScopeExtension full override

        /// <inheritdoc />
        [SuppressMessage(
            "Design",
            "CA1033:Interface methods should be callable by child types",
            Justification = "All inheritors can just modify ScopeErrorReThrowRequired")]
        bool IAsyncCodeScopeExtension.IsRethrowRequired => ScopeErrorReThrowRequired;

        /// <inheritdoc />
        ValueTask IAsyncCodeScopeExtension.OnLoseCodeScopeAsync(Exception? ex)
        {
            TryCloseAsync(ex, out var task);
            return task;
        }

        #endregion

        #region IAsyncDisposeable full override

        /// <inheritdoc />
        ValueTask IAsyncDisposable.DisposeAsync()
        {
            TryCloseAsync(null, out var task);
            return task;
        }

        #endregion

        #region IAsyncCloseable

        /// <inheritdoc />
        public ValueTask CloseAsync()
        {
            return TryCloseAsync(null, out var closeTask)
                ? closeTask
                : new ValueTask(Task.FromException(new ObjectClosedException(this)));
        }

        /// <summary>
        ///     Tries to close the object asynchronously, if close wasn't yet requested.
        /// </summary>
        /// <param name="closeTask">
        ///     Receives the awaitable result of the close asynchronous operation. The task will completes when
        ///     object switches to the "closed" state.
        /// </param>
        /// <returns>
        ///     <see langword="true" /> if close has been requested this call or <see langword="false" /> if object close was was
        ///     already requested.
        /// </returns>
        public bool TryCloseAsync(out ValueTask closeTask)
        {
            return TryCloseAsync(null, out closeTask);
        }

        #endregion

#pragma warning restore SA1201 // Elements should appear in the correct order
    }
}
