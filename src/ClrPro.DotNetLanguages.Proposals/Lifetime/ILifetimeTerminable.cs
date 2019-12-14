using JetBrains.Annotations;

namespace System
{
    /// <summary>
    ///     <see cref="ILifetimeExplicit" /> object which support non-graceful lifetime termination.
    /// </summary>
    [PublicAPI]
    public interface ILifetimeTerminable : ILifetimeExplicit
    {
        /// <summary>
        ///     Terminates lifetime. Mutually exclusive with <see cref="ILifetimeExplicit.Dispose" /> supports one and only one
        ///     invocation.
        /// </summary>
        /// <param name="reasonException">The error caused lifetime termination.</param>
        void Terminate(Exception reasonException)
        {
            Dispose();
        }
    }
}