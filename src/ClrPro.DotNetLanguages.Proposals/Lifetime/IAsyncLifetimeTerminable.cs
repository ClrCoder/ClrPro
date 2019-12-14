using System.Threading.Tasks;
using JetBrains.Annotations;

namespace System
{
    /// <summary>
    ///     <see cref="IAsyncLifetimeExplicit" /> object which support non-graceful lifetime termination.
    /// </summary>
    [PublicAPI]
    public interface IAsyncLifetimeTerminable : IAsyncLifetimeExplicit
    {
        /// <summary>
        ///     Terminates lifetime. Mutually exclusive with <see cref="IAsyncLifetimeExplicit.DisposeAsync" /> supports one and
        ///     only one invocation.
        /// </summary>
        /// <param name="reasonException">The error caused lifetime termination.</param>
        /// <returns>Async terminate operation task.</returns>
        ValueTask TerminateAsync(Exception reasonException);
    }
}