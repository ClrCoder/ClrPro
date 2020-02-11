// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Tasks
{
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     Task related extensions.
    /// </summary>
    [PublicAPI]
    public static class ClrProTasksExtensions
    {
        /// <summary>
        ///     Subscribes action on the completion of the <see cref="ValueTask" />.
        /// </summary>
        /// <remarks>TODO: Make the same method but for the action with the result.</remarks>
        /// <typeparam name="TState">The type of the state argument to the action.</typeparam>
        /// <param name="task">The task to await.</param>
        /// <param name="action">The action to run when the task completes.</param>
        /// <param name="state">The state argument for the action.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UnsafeContinueWith<TState>(
            in this ValueTask task,
            Action<TaskCompletionResult, TState> action,
            TState state)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Subscribes <see cref="ITaskCompletionSource" /> on the completion of the task.
        /// </summary>
        /// <typeparam name="TCompletionSource">The type of the completion source.</typeparam>
        /// <param name="task">The task to await.</param>
        /// <param name="completionSource">The completion source object.</param>
        public static void ContinueWith<TCompletionSource>(in this ValueTask task, TCompletionSource completionSource)
            where TCompletionSource : ITaskCompletionSource
        {
            throw new NotImplementedException();
        }
    }
}
