// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using System.Runtime.CompilerServices;
    using BenchmarkDotNet.Attributes;

    [InProcess]
    public class InterlockedAlignmentBenchmark
    {
        private const int IterationsCount = 1000_000;
        private readonly long[] _mem = new long[4096];

        [Benchmark(Baseline = true)]
        public unsafe void InterlockedIncrement64BitAlignment()
        {
            var arrayPtr = (ulong)Unsafe.AsPointer(ref _mem[0]);
            arrayPtr = ((arrayPtr + 1024UL) & ~1023UL) - 8; // Align to 8 byte in memory.
            ref var state = ref Unsafe.AsRef<long>((void*)arrayPtr);

            for (var i = 0; i < IterationsCount / 10; i++)
            {
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);

                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
            }
        }

        [Benchmark]
        public unsafe void InterlockedIncrement128BitAlignment()
        {
            var arrayPtr = (ulong)Unsafe.AsPointer(ref _mem[0]);
            arrayPtr = ((arrayPtr + 1024UL) & ~1023UL) - 16; // Align to 8 byte in memory.
            ref var state = ref Unsafe.AsRef<long>((void*)arrayPtr);

            for (var i = 0; i < IterationsCount / 10; i++)
            {
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);

                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
            }
        }

        [Benchmark]
        public unsafe void InterlockedIncrement32BitAlignment()
        {
            var arrayPtr = (ulong)Unsafe.AsPointer(ref _mem[0]);
            arrayPtr = ((arrayPtr + 1024UL) & ~1023UL) - 4; // Align to 4 byte in memory.
            ref var state = ref Unsafe.AsRef<long>((void*)arrayPtr);

            for (var i = 0; i < IterationsCount / 10; i++)
            {
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);

                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
            }
        }

        [Benchmark]
        public unsafe void InterlockedIncrement16BitAlignment()
        {
            var arrayPtr = (ulong)Unsafe.AsPointer(ref _mem[0]);
            arrayPtr = ((arrayPtr + 1024UL) & ~1023UL) - 2; // Align to 4 byte in memory.
            ref var state = ref Unsafe.AsRef<long>((void*)arrayPtr);

            for (var i = 0; i < IterationsCount / 10; i++)
            {
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);

                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
            }
        }

        [Benchmark]
        public unsafe void InterlockedIncrement8BitAlignment()
        {
            var arrayPtr = (ulong)Unsafe.AsPointer(ref _mem[0]);
            arrayPtr = ((arrayPtr + 1024UL) & ~1023UL) - 1; // Align to 4 byte in memory.
            ref var state = ref Unsafe.AsRef<long>((void*)arrayPtr);

            for (var i = 0; i < IterationsCount / 10; i++)
            {
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);

                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
                Interlocked.Increment(ref state);
            }
        }
    }
}
