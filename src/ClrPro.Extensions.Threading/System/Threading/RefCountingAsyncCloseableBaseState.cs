// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using JetBrains.Annotations;

    // TODO: Pack the state into machine word (sizeof(IntPtr)) to allow 32bit/64bit Hardware Atomic (Interlocked).

    /// <summary>
    ///     Simple implementation of the <see cref="IAsyncCloseableBaseState" /> which tracks pending operation through
    ///     a reference counting.
    /// </summary>
    [PublicAPI]
    [SuppressMessage(
        "Performance",
        "CA1815:Override equals and operator equals on value types",
        Justification = "We needs to not encourage to use direct comparision of the state in code.")]
    [SuppressMessage(
        "Usage",
        "CA2231:Overload operator equals on overriding value type Equals",
        Justification = "We needs to not encourage to use direct comparision of the state in code.")]
    public struct RefCountingAsyncCloseableBaseState : IAsyncCloseableBaseState,
        IEquatable<RefCountingAsyncCloseableBaseState>
    {
        private int _referencesCount;

        private ClosingStatus _status;

        private bool _wasTerminated;

        private bool _wasClosedCritical;

        /// <summary>
        ///     The currently allocated references count.
        /// </summary>
        public int ReferencesCount => _referencesCount;

        /// <inheritdoc />
        public ClosingStatus Status => _status;

        /// <inheritdoc />
        public bool WasTerminated => _wasTerminated;

        /// <inheritdoc />
        public bool WasClosedCritical => _wasClosedCritical;

        /// <inheritdoc />
        public bool Equals(RefCountingAsyncCloseableBaseState other)
        {
            return _referencesCount == other._referencesCount
                   && _status == other._status
                   && _wasTerminated == other._wasTerminated
                   && _wasClosedCritical == other._wasClosedCritical;
        }

        /// <inheritdoc />
        public bool AcceptCloseRequest(bool isTerminating)
        {
            Debug.Assert(_status == ClosingStatus.Alive, "Close can be requested only in Alive state.");

            var switchToClosingState = _referencesCount == 0;
            _status = switchToClosingState ? ClosingStatus.Closing : ClosingStatus.CloseRequested;

            if (switchToClosingState)
            {
                _wasTerminated = isTerminating;
            }

            return switchToClosingState;
        }

        /// <inheritdoc />
        public bool AreOperationsPending()
        {
            return _referencesCount != 0;
        }

        /// <inheritdoc />
        public void SetClosed()
        {
            Debug.Assert(
                _status == ClosingStatus.Closing,
                "Switch to 'Closed' state should be performed only from 'Closing' state.");

            _status = ClosingStatus.Closed;
        }

        /// <inheritdoc />
        public void SetClosedCritical()
        {
            _wasClosedCritical = true;
            _status = ClosingStatus.Closed;
        }

        /// <summary>
        ///     Adds a reference.
        /// </summary>
        public void AddRef()
        {
            Debug.Assert(
                _status == ClosingStatus.Alive || _status == ClosingStatus.CloseRequested,
                "Reference can be added only in Alive or CloseRequested state.");
            Debug.Assert(
                _status != ClosingStatus.CloseRequested || _referencesCount > 0,
                "It's impossible to have CloseRequested state and zero reference counter.");

            _referencesCount++;
        }

        /// <summary>
        ///     Releases a reference.
        /// </summary>
        /// <returns><see langword="true" /> if there were a CloseRequested state and after the last reference were released.</returns>
        public bool ReleaseRef()
        {
            Debug.Assert(_referencesCount > 0, "Reference can be released only when the counter is greater than zero.");

            _referencesCount--;

            var pendingOperationsCompleted = _referencesCount == 0 && _status == ClosingStatus.CloseRequested;
            if (pendingOperationsCompleted)
            {
                _status = ClosingStatus.Closing;
            }

            return pendingOperationsCompleted;
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            return obj is RefCountingAsyncCloseableBaseState other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            // Hashcode is useless for a mutable structure.
            return 0;
        }
    }
}
