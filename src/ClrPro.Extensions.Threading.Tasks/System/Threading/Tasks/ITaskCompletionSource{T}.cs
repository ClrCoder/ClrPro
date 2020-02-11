// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Tasks
{
    using JetBrains.Annotations;

    /// <summary>
    ///     The asynchronous result producer side abstraction.
    /// </summary>
    /// <typeparam name="T">The type of the value of the completion.</typeparam>
    [PublicAPI]
    public interface ITaskCompletionSource<in T>
    {
        /// <summary>
        ///     Sets the result of the operation.
        /// </summary>
        /// <param name="completionResult">The completion result.</param>
        /// <param name="result">The value of the completion.</param>
        void SetCompletionResult(TaskCompletionResult completionResult, T result);
    }
}
