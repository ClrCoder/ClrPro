using JetBrains.Annotations;

namespace System.Runtime.CompilerServices
{
    /// <summary>
    ///     Scoped language construct extension, primarily <see langword="using" /> statement.
    /// </summary>
    [PublicAPI]
    public interface ICodeScopeExtension
    {
        /// <summary>
        ///     Executed by a language construct when the language construct looses its scope.
        /// </summary>
        /// <param name="exception">
        ///     Exception that was caused the scope loosing, or <see langword="null" /> for a normal execution
        ///     flow.
        /// </param>
        void OnLooseCodeScope(Exception? exception);
    }
}