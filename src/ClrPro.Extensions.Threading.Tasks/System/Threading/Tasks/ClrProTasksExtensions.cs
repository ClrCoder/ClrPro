// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Tasks
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     Task related extensions.
    /// </summary>
    [PublicAPI]
    public static class ClrProTasksExtensions
    {
        /// <summary>
        ///     Subscribes action on the completion of the <see cref="ValueTask" /> without capturing the execution context.
        /// </summary>
        /// <typeparam name="TState">The type of the state argument to the action.</typeparam>
        /// <param name="task">The task to await.</param>
        /// <param name="action">The action to run when the task completes.</param>
        /// <param name="state">The state argument for the action.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Reviewed")]
        [SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Reviewed")]
        [SuppressMessage("ReSharper", "PossibleNullReferenceException", Justification = "Reviewed")]
        public static void UnsafeContinueWith<TState>(
            in this ValueTask task,
            Action<TaskCompletionResult, TState> action,
            TState state)
        {
            if (action == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.action);
            }

            if (task.IsCompleted)
            {
                if (task.IsCompletedSuccessfully)
                {
                    // We needs to call result to finalize async protocol.
                    task.GetAwaiter().GetResult();

                    action(default, state);
                }
                else
                {
                    UnsafeContinueWithSlow(task, action, state);
                }
            }
            else
            {
                var awaiter = task.ConfigureAwait(false).GetAwaiter();
                awaiter.OnCompleted(
                    () =>
                    {
                        var wasCallbackCalled = false;
                        try
                        {
                            // We needs to call result to finalize async protocol.
                            awaiter.GetResult();

                            wasCallbackCalled = true;
                            action(default, state);
                        }
                        catch (Exception ex)
                        {
                            if (!wasCallbackCalled)
                            {
                                action(TaskCompletionResult.CaptureFromException(ex), state);
                            }
                        }
                    });
            }
        }

        /// <summary>
        ///     Subscribes action on the completion of the <see cref="ValueTask" /> without capturing the execution context.
        /// </summary>
        /// <typeparam name="TValue">The type of the value to await.</typeparam>
        /// <typeparam name="TState">The type of the state argument to the action.</typeparam>
        /// <param name="task">The task to await.</param>
        /// <param name="action">The action to run when the task completes.</param>
        /// <param name="state">The state argument for the action.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Reviewed")]
        [SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Reviewed")]
        [SuppressMessage("ReSharper", "PossibleNullReferenceException", Justification = "Reviewed")]
        public static void UnsafeContinueWith<TValue, TState>(
            in this ValueTask<TValue> task,
            Action<TaskCompletionResult, TValue, TState> action,
            TState state)
        {
            if (action == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.action);
            }

            if (task.IsCompleted)
            {
                if (task.IsCompletedSuccessfully)
                {
                    action(default, task.Result, state);
                }
                else
                {
                    UnsafeContinueWithSlow(task, action, state);
                }
            }
            else
            {
                var awaiter = task.ConfigureAwait(false).GetAwaiter();
                awaiter.OnCompleted(
                    () =>
                    {
                        var wasCallbackCalled = false;
                        try
                        {
                            var result = awaiter.GetResult();
                            wasCallbackCalled = true;
                            action(default, result, state);
                        }
                        catch (Exception ex)
                        {
                            if (!wasCallbackCalled)
                            {
                                action(TaskCompletionResult.CaptureFromException(ex), default!, state);
                            }
                        }
                    });
            }
        }

        /// <summary>
        ///     Subscribes <see cref="ITaskCompletionSource" /> on the completion of the task.
        /// </summary>
        /// <typeparam name="TCompletionSource">The type of the completion source.</typeparam>
        /// <param name="task">The task to await.</param>
        /// <param name="completionSource">The completion source object.</param>
        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Reviewed")]
        [SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Reviewed")]
        [SuppressMessage("ReSharper", "PossibleNullReferenceException", Justification = "Reviewed")]
        public static void ContinueWith<TCompletionSource>(in this ValueTask task, TCompletionSource completionSource)
            where TCompletionSource : ITaskCompletionSource
        {
            if (completionSource == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.completionSource);
            }

            if (task.IsCompleted)
            {
                if (task.IsCompletedSuccessfully)
                {
                    // We needs to call result to finalize async protocol.
                    task.GetAwaiter().GetResult();

                    completionSource.SetCompletionResult(default);
                }
                else
                {
                    UnsafeContinueWithSlow(task, completionSource);
                }
            }
            else
            {
                var awaiter = task.ConfigureAwait(false).GetAwaiter();
                awaiter.OnCompleted(
                    () =>
                    {
                        var wasCallbackCalled = false;
                        try
                        {
                            awaiter.GetResult();
                            wasCallbackCalled = true;
                            completionSource.SetCompletionResult(default);
                        }
                        catch (Exception ex)
                        {
                            if (!wasCallbackCalled)
                            {
                                completionSource.SetCompletionResult(TaskCompletionResult.CaptureFromException(ex));
                            }
                        }
                    });
            }
        }

        /// <summary>
        ///     Subscribes <see cref="ITaskCompletionSource" /> on the completion of the task.
        /// </summary>
        /// <typeparam name="TValue">The type of the value to await.</typeparam>
        /// <typeparam name="TCompletionSource">The type of the completion source.</typeparam>
        /// <param name="task">The task to await.</param>
        /// <param name="completionSource">The completion source object.</param>
        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Reviewed")]
        [SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Reviewed")]
        [SuppressMessage("ReSharper", "PossibleNullReferenceException", Justification = "Reviewed")]
        public static void ContinueWith<TValue, TCompletionSource>(
            in this ValueTask<TValue> task,
            TCompletionSource completionSource)
            where TCompletionSource : ITaskCompletionSource<TValue>
        {
            if (completionSource == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.completionSource);
            }

            if (task.IsCompleted)
            {
                if (task.IsCompletedSuccessfully)
                {
                    completionSource.SetCompletionResult(default, task.Result);
                }
                else
                {
                    UnsafeContinueWithSlow(task, completionSource);
                }
            }
            else
            {
                var awaiter = task.ConfigureAwait(false).GetAwaiter();
                awaiter.OnCompleted(
                    () =>
                    {
                        var wasCallbackCalled = false;
                        try
                        {
                            var result = awaiter.GetResult();
                            wasCallbackCalled = true;
                            completionSource.SetCompletionResult(default, result);
                        }
                        catch (Exception ex)
                        {
                            if (!wasCallbackCalled)
                            {
                                completionSource.SetCompletionResult(
                                    TaskCompletionResult.CaptureFromException(ex),
                                    default!);
                            }
                        }
                    });
            }
        }

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Reviewed")]
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void UnsafeContinueWithSlow<TState>(
            in this ValueTask task,
            Action<TaskCompletionResult, TState> action,
            TState state)
        {
            var wasActionCalled = false;
            try
            {
                task.ConfigureAwait(false).GetAwaiter().GetResult();
                wasActionCalled = true;
                action(default, state);
            }
            catch (Exception ex)
            {
                if (wasActionCalled)
                {
                    action(TaskCompletionResult.CaptureFromException(ex), state);
                }
            }
        }

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Reviewed")]
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void UnsafeContinueWithSlow<TValue, TState>(
            in this ValueTask<TValue> task,
            Action<TaskCompletionResult, TValue, TState> action,
            TState state)
        {
            var wasActionCalled = false;
            try
            {
                var result = task.Result;
                wasActionCalled = true;
                action(default, result, state);
            }
            catch (Exception ex)
            {
                if (wasActionCalled)
                {
                    action(TaskCompletionResult.CaptureFromException(ex), default!, state);
                }
            }
        }

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Reviewed")]
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void UnsafeContinueWithSlow<TCompletionSource>(
            in this ValueTask task,
            TCompletionSource completionSource)
            where TCompletionSource : ITaskCompletionSource
        {
            var wasCompletionSource = false;
            try
            {
                task.ConfigureAwait(false).GetAwaiter().GetResult();
                wasCompletionSource = true;
                completionSource.SetCompletionResult(default);
            }
            catch (Exception ex)
            {
                if (wasCompletionSource)
                {
                    completionSource.SetCompletionResult(TaskCompletionResult.CaptureFromException(ex));
                }
            }
        }

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Reviewed")]
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void UnsafeContinueWithSlow<TValue, TCompletionSource>(
            in this ValueTask<TValue> task,
            TCompletionSource completionSource)
            where TCompletionSource : ITaskCompletionSource<TValue>
        {
            var wasCompletionSource = false;
            try
            {
                var result = task.Result;
                wasCompletionSource = true;
                completionSource.SetCompletionResult(default, result);
            }
            catch (Exception ex)
            {
                if (wasCompletionSource)
                {
                    completionSource.SetCompletionResult(TaskCompletionResult.CaptureFromException(ex), default!);
                }
            }
        }
    }
}
