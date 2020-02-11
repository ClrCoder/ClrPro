// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Xunit;
    using Xunit.Abstractions;

    public class ConcurrentExceptionReThrowTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public ConcurrentExceptionReThrowTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        /// <summary>
        ///     Reproduction code for the https://github.com/dotnet/runtime/issues/32009.
        /// </summary>
        /// <returns>The async execution task.</returns>
        [Fact]
        [Trait("Category", "Manual")]
        public async Task SomeTest()
        {
            var faultedTask = Task.Run(
                () => throw new InvalidOperationException("Test exception"));

            ////var completionSource = new TaskCompletionSource<bool>();
            ////try
            ////{
            ////    throw new InvalidOperationException("Test exception");
            ////}
            ////catch (InvalidOperationException ex)
            ////{
            ////    completionSource.SetException(ex);
            ////}

            var tasksToWait = new List<Task>();

            for (var i = 0; i < 10; i++)
            {
                var task = (i & 1) == 0
                    ? Task.Run(() => OneUsage(faultedTask))
                    : Task.Run(() => SecondUsage(faultedTask));
                tasksToWait.Add(task);
            }

            // Waiting all tasks to complete.
            foreach (var t in tasksToWait)
            {
                await t;
            }
        }

        private async void SecondUsage(Task taskToWait)
        {
            try
            {
                await taskToWait.ConfigureAwait(false);
            }
            catch (InvalidOperationException ex)
            {
                var str = ex.ToString();
                if (str.Contains("OneUsage", StringComparison.InvariantCulture))
                {
                    _outputHelper.WriteLine("----\nSecondUsage saw stacktrace from OneUsage:\n" + str);
                }
            }
        }

        private async Task OneUsage(Task taskToWait)
        {
            try
            {
                await taskToWait.ConfigureAwait(false);
            }
            catch (InvalidOperationException ex)
            {
                var str = ex.ToString();
                if (str.Contains("SecondUsage", StringComparison.InvariantCulture))
                {
                    _outputHelper.WriteLine("----\nOneUsage saw stacktrace from SecondUsage:\n" + str);
                }
            }
        }
    }
}
