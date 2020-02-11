// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading.Tasks
{
    using JetBrains.Annotations;

    /// <summary>
    ///     The asynchronous result producer side abstraction.
    /// </summary>
    [PublicAPI]
    public interface ITaskCompletionSource
    {
        /// <summary>
        ///     Sets the result of the operation.
        /// </summary>
        /// <param name="completionResult">The result of the asynchronous operation.</param>
        void SetCompletion(TaskCompletionResult completionResult);
    }
}
