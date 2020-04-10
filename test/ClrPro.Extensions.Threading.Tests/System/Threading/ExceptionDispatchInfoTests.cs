// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;
    using Xunit;
    using Xunit.Abstractions;

    [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Reviewed")]
    [SuppressMessage(
        "StyleCop.CSharp.MaintainabilityRules",
        "SA1405:Debug.Assert should provide message text",
        Justification = "Reviewed")]
    public class ExceptionDispatchInfoTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public ExceptionDispatchInfoTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        [Trait("Category", "Manual")]
        public void TestDispatchInfo()
        {
            var exception = GenerateException();
            _outputHelper.WriteLine(exception.ToString());

            // We were generated the exception at the different thread, different location.
            var completionSource = new TaskCompletionSource<bool>();
            completionSource.SetException(exception);
            var reThrownException = GetRethrownException(completionSource);

            _outputHelper.WriteLine("ReThrownException:");
            _outputHelper.WriteLine(reThrownException.ToString());
        }

        private static Exception GenerateException()
        {
            Exception? exception = null;
            var t = new Thread(
                () =>
                {
                    try
                    {
                        throw new InvalidOperationException("Test error!");
                    }
                    catch (Exception ex)
                    {
                        exception = ex;
                    }
                });
            t.Start();
            t.Join();
            Debug.Assert(exception != null);
            return exception;
        }

        private static Exception GetRethrownException(TaskCompletionSource<bool> completionSource)
        {
            Exception? exception = null;
            var t = new Thread(
                () =>
                {
                    Task.Run(
                        async () =>
                        {
                            try
                            {
                                await completionSource.Task.ConfigureAwait(false);
                            }
                            catch (Exception ex)
                            {
                                exception = ex;
                            }
                        }).GetAwaiter().GetResult();
                });
            t.Start();
            t.Join();
            Debug.Assert(exception != null);
            return exception;
        }
    }
}
