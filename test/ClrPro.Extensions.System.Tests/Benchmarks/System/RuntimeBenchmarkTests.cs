// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Loggers;
    using BenchmarkDotNet.Running;
    using Xunit;
    using Xunit.Abstractions;

    [Trait("Category", "QuickBench")]
    public class RuntimeBenchmarkTests
    {
        private readonly ITestOutputHelper _testOutput;

        public RuntimeBenchmarkTests(ITestOutputHelper testOutput)
        {
            _testOutput = testOutput;
        }

        [Fact]
        public void Benchmark()
        {
            var logger = new AccumulationLogger();
            var config = DefaultConfig.Instance.With(logger);
            var summary = BenchmarkRunner.Run<RuntimeBenchmark>(config);
            _testOutput.WriteLine(logger.GetLog());
        }
    }
}
