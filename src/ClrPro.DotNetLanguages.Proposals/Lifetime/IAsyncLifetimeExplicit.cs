using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace System
{
    /// <summary>
    ///     Explicit lifetime object suitable for async environment.
    /// </summary>
    [PublicAPI]
    public interface IAsyncLifetimeExplicit : IAsyncCodeScopeExtension
    {
        /// <summary>
        ///     Gracefully finishes lifetime of the object. Supports one and only one invocation.
        /// </summary>
        /// <remarks>
        ///     Implementation guide:
        ///     <list type="bullet">
        ///         <item>
        ///             <description>
        ///                 Should not throw exception, except <see cref="ObjectDisposedException" /> on second and
        ///                 subsequent call.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <description>
        ///                 After the end of the object lifetime, all operations on the object should throw
        ///                 <see cref="ObjectDisposedException" />.
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <description>
        ///                 TODO: Describe more implementation details, including: reentrancy, concurrency, inheritance, etc.
        ///             </description>
        ///         </item>
        ///     </list>
        /// </remarks>
        /// <returns>Asynchronous operation which finishes lifetime of the object.</returns>
        ValueTask DisposeAsync();

        ValueTask IAsyncCodeScopeExtension.OnLooseCodeScopeAsync(Exception? exception)
        {
            return DisposeAsync();
        }
    }
}