// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using System.Linq;
    using System.Reflection;

    /// <summary>
    ///     This shim is required to fill gaps between NetStandard 2.1 and NetCoreApp 3.0.
    /// </summary>
    internal static class ThreadPoolShim
    {
        static ThreadPoolShim()
        {
            var method = typeof(ThreadPool).GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(m => m.Name == "UnsafeQueueUserWorkItem")
                .Select(
                    m => new
                    {
                        Method = m,
                        Params = m.GetParameters(),
                        Args = m.GetGenericArguments(),
                    })
                .Where(
                    x => x.Params.Length == 3
                         && x.Args.Length == 1
                         && x.Params[1].ParameterType == x.Args[0]
                         && x.Params[2].ParameterType == typeof(bool))
                .Select(x => x.Method)
                .First();
            UnsafeQueueUserWorkItem = (Func<Action<object?>, object?, bool, bool>)method
                .MakeGenericMethod(typeof(object))
                .CreateDelegate(typeof(Func<Action<object?>, object?, bool, bool>));
        }

        /// <summary>
        ///     The action that corresponds to <c>ThreadPool.UnsafeQueueUserWorkItem{object}</c>.
        /// </summary>
        public static Func<Action<object?>, object?, bool, bool> UnsafeQueueUserWorkItem { get; }
    }
}
