// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>
    ///     The async closeable object. This is an extension to the <see cref="IAsyncDisposable" /> with better control over
    ///     lifetime of the object. It's asynchronous version of the <see cref="ICloseable" />.
    /// </summary>
    [PublicAPI]
    [SuppressMessage(
        "Design",
        "CA1033:Interface methods should be callable by child types",
        Justification = "C# 8.0 DIM is not supported yet by FxCop")]
    public interface IAsyncCloseable : IClosingStatusObservable, IAsyncDisposable, IAsyncCodeScopeExtension
    {
        /// <summary>
        ///     Closes the object asynchronously, or raises <see cref="ObjectClosedException" /> if close was already requested.
        /// </summary>
        /// <exception cref="ObjectClosedException">The close was already requested.</exception>
        /// <remarks>
        ///     <para>Use <see cref="IAsyncDisposable.DisposeAsync" /> method to support multiple close attempts scenarios.</para>
        /// </remarks>
        ValueTask CloseAsync()
        {
            return TryCloseAsync(out var closeTask)
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
        protected bool TryCloseAsync(out ValueTask closeTask);

        // ReSharper disable once CommentTypo
        // ReSharper disable once InheritdocInvalidUsage

        /// <inheritdoc />
        ValueTask IAsyncDisposable.DisposeAsync()
        {
            TryCloseAsync(out var closeTask);
            return closeTask;
        }

        // ReSharper disable once CommentTypo
        // ReSharper disable once InheritdocInvalidUsage

        /// <inheritdoc />
        ValueTask IAsyncCodeScopeExtension.OnLoseCodeScopeAsync(Exception? exception)
        {
            return CloseAsync();
        }
    }
}
