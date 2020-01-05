// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using JetBrains.Annotations;

    /// <summary>
    ///     The <see cref="ITerminable" /> object which can be closed forcefully with the specification of a error.
    /// </summary>
    [PublicAPI]
    [SuppressMessage(
        "Design",
        "CA1033:Interface methods should be callable by child types",
        Justification = "C# 8.0 DIM is not supported yet by FxCop")]
    public interface IAsyncTerminable : IAsyncCloseable
    {
        /// <summary>
        ///     The termination reason exception.
        /// </summary>
        Exception? TerminateReason { get; }

        /// <summary>
        ///     Terminates the object with the specified, if it hasn't been closed or terminated yet.
        /// </summary>
        /// <param name="reasonException">The termination reason exception.</param>
        /// <param name="terminateTask">Task that becomes completed when object completes termination.</param>
        /// <returns>
        ///     <see langword="true" /> if object has been terminated by this call or <see langword="false" /> if object was
        ///     already closed/terminated.
        /// </returns>
        bool TryTerminateAsync(Exception reasonException, out ValueTask terminateTask)
        {
            return TryCloseAsync(reasonException, out terminateTask);
        }

        /// <summary>
        ///     Terminates the object asynchronously, or raises <see cref="ObjectClosedException" /> if the object was already
        ///     closed/terminated.
        /// </summary>
        /// <exception cref="ObjectClosedException">The close/terminate was already requested.</exception>
        /// <remarks>
        ///     <para>Use <see cref="IDisposable.Dispose" /> method to support multiple close attempts scenarios.</para>
        /// </remarks>
        ValueTask TerminateAsync(Exception reasonException)
        {
            return TryTerminateAsync(reasonException, out var terminateTask)
                ? terminateTask
                : new ValueTask(Task.FromException(new ObjectClosedException(reasonException)));
        }

        /// <summary>
        ///     Tries to close the object asynchronously providing terminate reason exception or <see langword="null" /> in a case
        ///     of <see cref="IAsyncCloseable.TryCloseAsync" /> call.
        /// </summary>
        /// <param name="reasonException">The terminate reason exception.</param>
        /// <param name="closeTask">Task that becomes completed when object completes termination.</param>
        /// <returns>
        ///     <see langword="true" /> if object has been closed/terminated by this call or <see langword="false" /> if object was
        ///     already closed/terminated.
        /// </returns>
        protected bool TryCloseAsync(Exception? reasonException, out ValueTask closeTask);

        // ReSharper disable once CommentTypo
        // ReSharper disable once InheritdocInvalidUsage

        /// <inheritdoc />
        bool IAsyncCloseable.TryCloseAsync(out ValueTask closeTask)
        {
            return TryCloseAsync(null, out closeTask);
        }

        // ReSharper disable once CommentTypo
        // ReSharper disable once InheritdocInvalidUsage

        /// <inheritdoc />
        ValueTask IAsyncCodeScopeExtension.OnLoseCodeScopeAsync(Exception? exception)
        {
            return exception != null ? TerminateAsync(exception) : CloseAsync();
        }
    }
}
