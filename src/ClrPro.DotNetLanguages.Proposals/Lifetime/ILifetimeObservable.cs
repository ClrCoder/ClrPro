using JetBrains.Annotations;

namespace System
{
    /// <summary>
    ///     <see cref="ILifetimeExplicit" /> object whose lifetime state can be observed.
    /// </summary>
    [PublicAPI]
    public interface ILifetimeObservable : ILifetimeExplicit
    {
        /// <summary>
        ///     Lifetime state of the object.
        /// </summary>
        LifetimeExplicitState LifetimeState { get; }

        /// <summary>
        ///     Event raised when lifetime state switched to <see cref="LifetimeExplicitState.Disposing" />.
        /// </summary>
        event EventHandler Disposing;

        /// <summary>
        ///     Event raised when lifetime state switched to <see cref="LifetimeExplicitState.Disposed" />.
        /// </summary>
        event EventHandler Disposed;
    }
}