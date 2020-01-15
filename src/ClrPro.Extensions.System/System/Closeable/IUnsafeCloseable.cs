// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    /// <summary>
    ///     The resource which should be closed explicitly one time and only one time, otherwise unpredictable behavior occurs.
    ///     For example reference count based resource.
    /// </summary>
    [SuppressMessage(
        "Design",
        "CA1033:Interface methods should be callable by child types",
        Justification = "C# 8.0 DIM is not supported yet by FxCop")]
    [PublicAPI]
    public interface IUnsafeCloseable : ICodeScopeExtension
    {
        /// <summary>
        ///     Closes resource. The resource cannot control it's state due to any reason. The user of the
        ///     <see cref="IUnsafeCloseable" /> is responsible to control that one and only one call will be performed.
        /// </summary>
        void UnsafeClose();

        // ReSharper disable once CommentTypo
        // ReSharper disable once InheritdocInvalidUsage

        /// <inheritdoc />
        void ICodeScopeExtension.OnLoseCodeScope(Exception? exception)
        {
            UnsafeClose();
        }
    }
}
