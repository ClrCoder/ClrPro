using System.Threading.Tasks;
using JetBrains.Annotations;

namespace System
{
    /// <summary>
    ///     <see cref="IAsyncLifetimeExplicit" /> object whose lifetime state can be observed.
    /// </summary>
    [PublicAPI]
    public interface IAsyncLifetimeObservable : IAsyncLifetimeExplicit
    {
        /// <summary>
        ///     Lifetime state of the object.
        /// </summary>
        LifetimeExplicitState LifetimeState { get; }

        /// <summary>
        ///     Task that completes when the object switched from alive state.
        /// </summary>
        /// <remarks>
        ///     TODO: Define, what will happened if object instantly transfers from  alive to disposed state ?
        /// </remarks>
        ValueTask Disposing { get; }

        /// <summary>
        ///     Task that completes when the object lifetime completes.
        /// </summary>
        /// <remarks>This task is valid even if project is alive.</remarks>
        ValueTask Disposed { get; }
    }
}