// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace ClrPro.ESharpLang.Tests
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;
    using FluentAssertions;
    using Xunit;
    using static ESharp;

    [SuppressMessage(
        "Reliability",
        "CA2007:Consider calling ConfigureAwait on the awaited task",
        Justification = "No any synchronization context are used during tests.")]
    public class LambdaTests
    {
        [Fact]
        public void AsyncLambdaCaptureShouldCompile()
        {
            var noArgsAsyncAction = YA(async () => { await Task.Delay(1000); });
            noArgsAsyncAction.Should().BeOfType<Func<ValueTask>>();

            var asyncAction = YA(async (int t) => await Task.Delay(1000));
            asyncAction.Should().BeOfType<Func<int, ValueTask>>();

            var asyncFunc = YA(
                async () =>
                {
                    await Task.Delay(1000);
                    return 10;
                });
            asyncFunc.Should().BeOfType<Func<ValueTask<int>>>();
        }

        [Fact]
        public void LambdaCaptureShouldCompilable()
        {
            var noArgsAction = Y(() => { });
            noArgsAction.Should().BeOfType<Action>();

            var action = Y((int t) => Trace.WriteLine(t + "test"));
            action.Should().BeOfType<Action<int>>();

            var func = Y(() => 10);
            func.Should().BeOfType<Func<int>>();
        }

        [Fact]
        public void TaskAsyncLambdaCaptureShouldCompile()
        {
            var noArgsAsyncAction = YT(async () => { await Task.Delay(1000); });
            noArgsAsyncAction.Should().BeOfType<Func<Task>>();

            var asyncAction = YT(async (int t) => await Task.Delay(1000));
            asyncAction.Should().BeOfType<Func<int, Task>>();

            var asyncFunc = YT(
                async () =>
                {
                    await Task.Delay(1000);
                    return 10;
                });
            asyncFunc.Should().BeOfType<Func<Task<int>>>();
        }
    }
}
