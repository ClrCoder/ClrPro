using JetBrains.Annotations;

namespace System
{
    /// <summary>
    ///     State of a <see cref="ILifetimeExplicit" /> or a <see cref="IAsyncLifetimeExplicit" /> object.
    /// </summary>
    [PublicAPI]
    public enum LifetimeExplicitState
    {
        /// <summary>
        ///     Object is alive.
        /// </summary>
        Alive,

        /// <summary>
        ///     Shutdown inprogress.
        /// </summary>
        Disposing,

        /// <summary>
        ///     Object disposed.
        /// </summary>
        Disposed
    }
}