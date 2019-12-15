using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    /// <summary>
    ///     Scoped language construct asynchronous extension, primarily <see langword="using" /> statement.
    /// </summary>
    public interface IAsyncCodeScopeExtension
    {
        /// <summary>
        ///     Asynchronously executed by a language construct when the language construct looses its scope.
        /// </summary>
        /// <param name="exception">
        ///     Exception that was caused the scope loosing, or <see langword="null" /> for a normal execution
        ///     flow.
        /// </param>
        /// <returns>Async operation task.</returns>
        ValueTask OnLooseCodeScopeAsync(Exception? exception);
    }
}