using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace System
{
    /// <summary>
    ///     Extension methods replacing future behavior of the C# using operator.
    /// </summary>
    [PublicAPI]
    public static class CSharpProposalPolyfillExtensions
    {
        /// <summary>
        ///     Polyfill method for the proposed behavior of the using operator.
        /// </summary>
        /// <typeparam name="T">The type of the target usingOperatorTarget of the using operator.</typeparam>
        /// <param name="usingOperatorTarget">The target usingOperatorTarget of the using operator.</param>
        /// <param name="codeBlock">The code block to apply polyfill for. <see langword="null" /> supported for empty using. </param>
        public static void Using<T>(this T usingOperatorTarget, Action<T>? codeBlock)
            where T : ICodeScopeExtension
        {
            try
            {
                codeBlock?.Invoke(usingOperatorTarget);
            }
            catch (Exception ex)
            {
                usingOperatorTarget.OnLooseCodeScope(ex);
                throw;
            }

            usingOperatorTarget.OnLooseCodeScope(null);
        }

        /// <summary>
        ///     Polyfill method for the proposed behavior of the await using operator.
        /// </summary>
        /// <typeparam name="T">The type of the target usingOperatorTarget of the using operator.</typeparam>
        /// <param name="usingOperatorTarget">The target usingOperatorTarget of the using operator.</param>
        /// <param name="codeBlock">The code block to apply polyfill for. <see langword="null" /> supported for empty using. </param>
        /// <returns></returns>
        public static async ValueTask UsingAsyncValueTaskBlock<T>(this T usingOperatorTarget,
            Func<T, ValueTask>? codeBlock)
            where T : IAsyncCodeScopeExtension
        {
            try
            {
                if (codeBlock != null) await codeBlock(usingOperatorTarget);
            }
            catch (Exception ex)
            {
                await usingOperatorTarget.OnLooseCodeScopeAsync(ex);
                throw;
            }

            await usingOperatorTarget.OnLooseCodeScopeAsync(null);
        }

        /// <summary>
        ///     Polyfill method for the proposed behavior of the await using operator.
        /// </summary>
        /// <typeparam name="T">The type of the target usingOperatorTarget of the using operator.</typeparam>
        /// <param name="usingOperatorTarget">The target usingOperatorTarget of the using operator.</param>
        /// <param name="codeBlock">The code block to apply polyfill for. <see langword="null" /> supported for empty using. </param>
        public static async ValueTask UsingAsync<T>(this T usingOperatorTarget, Func<T, Task>? codeBlock)
            where T : IAsyncLifetimeExplicit
        {
            try
            {
                if (codeBlock != null) await codeBlock(usingOperatorTarget);
            }
            catch (Exception ex)
            {
                await usingOperatorTarget.OnLooseCodeScopeAsync(ex);
                throw;
            }

            await usingOperatorTarget.OnLooseCodeScopeAsync(null);
        }

        /// <summary>
        ///     Polyfill method for the proposed behavior of the await using operator.
        /// </summary>
        /// <typeparam name="T">The type of the target usingOperatorTarget of the using operator.</typeparam>
        /// <param name="usingOperatorTarget">The target usingOperatorTarget of the using operator.</param>
        /// <param name="codeBlock">The code block to apply polyfill for. <see langword="null" /> supported for empty using. </param>
        public static async ValueTask UsingAsyncVoidBlock<T>(this T usingOperatorTarget, Action<T>? codeBlock)
            where T : IAsyncLifetimeExplicit
        {
            try
            {
                codeBlock?.Invoke(usingOperatorTarget);
            }
            catch (Exception ex)
            {
                await usingOperatorTarget.OnLooseCodeScopeAsync(ex);
                throw;
            }

            await usingOperatorTarget.OnLooseCodeScopeAsync(null);
        }
    }
}