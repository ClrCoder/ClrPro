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
            where T : ILifetimeExplicit
        {
            switch (usingOperatorTarget)
            {
                case ILifetimeTerminable lifetimeTerminable:
                    try
                    {
                        codeBlock?.Invoke(usingOperatorTarget);
                    }
                    catch (Exception ex)
                    {
                        lifetimeTerminable.Terminate(ex);
                        throw;
                    }

                    lifetimeTerminable.Dispose();
                    break;
                default:
                    try
                    {
                        codeBlock?.Invoke(usingOperatorTarget);
                    }
                    finally
                    {
                        usingOperatorTarget?.Dispose();
                    }

                    break;
            }
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
            where T : IAsyncLifetimeExplicit
        {
            switch (usingOperatorTarget)
            {
                case IAsyncLifetimeTerminable lifetimeTerminable:
                    try
                    {
                        if (codeBlock != null) await codeBlock(usingOperatorTarget);
                    }
                    catch (Exception ex)
                    {
                        await lifetimeTerminable.TerminateAsync(ex);
                        throw;
                    }

                    await lifetimeTerminable.DisposeAsync();
                    break;
                default:
                    try
                    {
                        if (codeBlock != null) await codeBlock(usingOperatorTarget);
                    }
                    finally
                    {
                        await usingOperatorTarget.DisposeAsync();
                    }

                    break;
            }
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
            switch (usingOperatorTarget)
            {
                case IAsyncLifetimeTerminable lifetimeTerminable:
                    try
                    {
                        if (codeBlock != null) await codeBlock(usingOperatorTarget);
                    }
                    catch (Exception ex)
                    {
                        await lifetimeTerminable.TerminateAsync(ex);
                        throw;
                    }

                    await lifetimeTerminable.DisposeAsync();
                    break;
                default:
                    try
                    {
                        if (codeBlock != null) await codeBlock(usingOperatorTarget);
                    }
                    finally
                    {
                        await usingOperatorTarget.DisposeAsync();
                    }

                    break;
            }
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
            switch (usingOperatorTarget)
            {
                case IAsyncLifetimeTerminable lifetimeTerminable:
                    try
                    {
                        codeBlock?.Invoke(usingOperatorTarget);
                    }
                    catch (Exception ex)
                    {
                        await lifetimeTerminable.TerminateAsync(ex);
                        throw;
                    }

                    await lifetimeTerminable.DisposeAsync();
                    break;
                default:
                    try
                    {
                        codeBlock?.Invoke(usingOperatorTarget);
                    }
                    finally
                    {
                        await usingOperatorTarget.DisposeAsync();
                    }

                    break;
            }
        }
    }
}