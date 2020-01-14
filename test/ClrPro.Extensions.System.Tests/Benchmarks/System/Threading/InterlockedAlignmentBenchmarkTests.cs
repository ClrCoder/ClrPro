// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Loggers;
    using BenchmarkDotNet.Running;
    using Xunit;
    using Xunit.Abstractions;

    [Trait("Category", "QuickBench")]
    public class InterlockedAlignmentBenchmarkTests
    {
        private readonly ITestOutputHelper _testOutput;

        public InterlockedAlignmentBenchmarkTests(ITestOutputHelper testOutput)
        {
            _testOutput = testOutput;
        }

        [Fact]
        public void Benchmark()
        {
            var logger = new AccumulationLogger();
            var config = DefaultConfig.Instance.With(logger);
            BenchmarkRunner.Run<InterlockedAlignmentBenchmark>(config);
            _testOutput.WriteLine(logger.GetLog());
        }
    }
}
