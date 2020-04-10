// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System
{
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using BenchmarkDotNet.Attributes;
    using static ClrPro.ESharp;

    [InProcess]
    [SuppressMessage(
        "Performance",
        "CA1822:Mark members as static",
        Justification = "Just following BenchmarkDotNet pattern")]
    public class RuntimeBenchmark
    {
        private const int IterationsCount = 1000_000;
        private readonly object _guard = new object();
        private int _intState;
        private long _longState;
        private object _objState = "abc";

        private interface IDummy
        {
            void Test();
        }

        [Benchmark]
        public void EmptyLoop()
        {
            // ReSharper disable once EmptyForStatement
            for (var i = 0; i < IterationsCount; i++)
            {
                // Do nothing.
            }
        }

        [Benchmark]
        public void StaticMethodCall()
        {
            for (var i = 0; i < IterationsCount / 10; i++)
            {
                EmptyStaticMethod();
                EmptyStaticMethod();
                EmptyStaticMethod();
                EmptyStaticMethod();
                EmptyStaticMethod();

                EmptyStaticMethod();
                EmptyStaticMethod();
                EmptyStaticMethod();
                EmptyStaticMethod();
                EmptyStaticMethod();
            }
        }

        [Benchmark(Baseline = true)]
        public void MemberMethodCallNoArg()
        {
            for (var i = 0; i < IterationsCount / 10; i++)
            {
                EmptyMethod();
                EmptyMethod();
                EmptyMethod();
                EmptyMethod();
                EmptyMethod();

                EmptyMethod();
                EmptyMethod();
                EmptyMethod();
                EmptyMethod();
                EmptyMethod();
            }
        }

        [Benchmark]
        public void MemberMethodCall1Arg()
        {
            for (var i = 0; i < IterationsCount / 10; i++)
            {
                EmptyMethod(i);
                EmptyMethod(i);
                EmptyMethod(i);
                EmptyMethod(i);
                EmptyMethod(i);

                EmptyMethod(i);
                EmptyMethod(i);
                EmptyMethod(i);
                EmptyMethod(i);
                EmptyMethod(i);
            }
        }

        [Benchmark]
        public void MemberMethodCall2Arg()
        {
            object tst = "arg";

            for (var i = 0; i < IterationsCount / 10; i++)
            {
                EmptyMethod(i, tst);
                EmptyMethod(i, tst);
                EmptyMethod(i, tst);
                EmptyMethod(i, tst);
                EmptyMethod(i, tst);

                EmptyMethod(i, tst);
                EmptyMethod(i, tst);
                EmptyMethod(i, tst);
                EmptyMethod(i, tst);
                EmptyMethod(i, tst);
            }
        }

        [Benchmark]
        public void MemberMethodCall2ArgRet()
        {
            object res = "arg";
            for (var i = 0; i < IterationsCount / 10; i++)
            {
                res = EmptyMethodRet(i, res);
                res = EmptyMethodRet(i, res);
                res = EmptyMethodRet(i, res);
                res = EmptyMethodRet(i, res);
                res = EmptyMethodRet(i, res);

                res = EmptyMethodRet(i, res);
                res = EmptyMethodRet(i, res);
                res = EmptyMethodRet(i, res);
                res = EmptyMethodRet(i, res);
                res = EmptyMethodRet(i, res);
            }
        }

        [Benchmark]
        public void VirtualMethodCall()
        {
            var dummy = Y(() => (IDummy)new SimpleDummy())();

            for (var i = 0; i < IterationsCount / 10; i++)
            {
                dummy.Test();
                dummy.Test();
                dummy.Test();
                dummy.Test();
                dummy.Test();

                dummy.Test();
                dummy.Test();
                dummy.Test();
                dummy.Test();
                dummy.Test();
            }
        }

        [Benchmark]
        [SuppressMessage("Usage", "CA1806:Do not ignore method results", Justification = "It's a performance check.")]
        public void ObjectCreation()
        {
            var optimizeGuard = Y(
                (
                    object a1,
                    object a2,
                    object a3,
                    object a4,
                    object a5,
                    object a6,
                    object a7,
                    object a8,
                    object a9,
                    object a10) =>
                {
                });
            for (var i = 0; i < IterationsCount / 10; i++)
            {
                optimizeGuard(
                    new DummyObject(),
                    new DummyObject(),
                    new DummyObject(),
                    new DummyObject(),
                    new DummyObject(),
                    new DummyObject(),
                    new DummyObject(),
                    new DummyObject(),
                    new DummyObject(),
                    new DummyObject());
            }
        }

        [Benchmark]
        public void ActionCall()
        {
            var a = Y(() => { });
            for (var i = 0; i < IterationsCount / 10; i++)
            {
                a();
                a();
                a();
                a();
                a();

                a();
                a();
                a();
                a();
                a();
            }
        }

        [Benchmark]
        public void LockOperator()
        {
            for (var i = 0; i < IterationsCount / 10; i++)
            {
                lock (_guard)
                {
                }

                lock (_guard)
                {
                }

                lock (_guard)
                {
                }

                lock (_guard)
                {
                }

                lock (_guard)
                {
                }

                lock (_guard)
                {
                }

                lock (_guard)
                {
                }

                lock (_guard)
                {
                }

                lock (_guard)
                {
                }

                lock (_guard)
                {
                }
            }
        }

        [Benchmark]
        public void IntInterlockedIncrement()
        {
            for (var i = 0; i < IterationsCount / 10; i++)
            {
                Interlocked.Increment(ref _intState);
                Interlocked.Increment(ref _intState);
                Interlocked.Increment(ref _intState);
                Interlocked.Increment(ref _intState);
                Interlocked.Increment(ref _intState);

                Interlocked.Increment(ref _intState);
                Interlocked.Increment(ref _intState);
                Interlocked.Increment(ref _intState);
                Interlocked.Increment(ref _intState);
                Interlocked.Increment(ref _intState);
            }

            Trace.WriteLine(_longState);
        }

        [Benchmark]
        public void IntCompareExchange()
        {
            var observedState = 0;
            for (var i = 0; i < IterationsCount / 10; i++)
            {
                observedState = Interlocked.CompareExchange(ref _intState, 10, observedState);
                observedState = Interlocked.CompareExchange(ref _intState, 11, observedState);
                observedState = Interlocked.CompareExchange(ref _intState, 12, observedState);
                observedState = Interlocked.CompareExchange(ref _intState, 13, observedState);
                observedState = Interlocked.CompareExchange(ref _intState, 14, observedState);

                observedState = Interlocked.CompareExchange(ref _intState, 20, observedState);
                observedState = Interlocked.CompareExchange(ref _intState, 21, observedState);
                observedState = Interlocked.CompareExchange(ref _intState, 22, observedState);
                observedState = Interlocked.CompareExchange(ref _intState, 23, observedState);
                observedState = Interlocked.CompareExchange(ref _intState, 24, observedState);
            }

            Trace.WriteLine(_longState);
        }

        [Benchmark]
        public void LongCompareExchange()
        {
            long observedState = 0;
            for (var i = 0; i < IterationsCount / 10; i++)
            {
                observedState = Interlocked.CompareExchange(ref _longState, 10L, observedState);
                observedState = Interlocked.CompareExchange(ref _longState, 12L, observedState);
                observedState = Interlocked.CompareExchange(ref _longState, 13L, observedState);
                observedState = Interlocked.CompareExchange(ref _longState, 14L, observedState);
                observedState = Interlocked.CompareExchange(ref _longState, 15L, observedState);

                observedState = Interlocked.CompareExchange(ref _longState, 16L, observedState);
                observedState = Interlocked.CompareExchange(ref _longState, 17L, observedState);
                observedState = Interlocked.CompareExchange(ref _longState, 18L, observedState);
                observedState = Interlocked.CompareExchange(ref _longState, 19L, observedState);
                observedState = Interlocked.CompareExchange(ref _longState, 20L, observedState);
            }

            Trace.WriteLine(_longState);
        }

        [Benchmark]
        public void ObjectCompareExchange()
        {
            object observedState = 0;
            for (var i = 0; i < IterationsCount / 10; i++)
            {
                observedState = Interlocked.CompareExchange(ref _objState, "test", observedState);
                observedState = Interlocked.CompareExchange(ref _objState, "test1", observedState);
                observedState = Interlocked.CompareExchange(ref _objState, "test2", observedState);
                observedState = Interlocked.CompareExchange(ref _objState, "test3", observedState);
                observedState = Interlocked.CompareExchange(ref _objState, "test4", observedState);

                observedState = Interlocked.CompareExchange(ref _objState, "test", observedState);
                observedState = Interlocked.CompareExchange(ref _objState, "test1", observedState);
                observedState = Interlocked.CompareExchange(ref _objState, "test2", observedState);
                observedState = Interlocked.CompareExchange(ref _objState, "test3", observedState);
                observedState = Interlocked.CompareExchange(ref _objState, "test4", observedState);
            }

            Trace.WriteLine(_objState);
        }

        [Benchmark]
        public void IntIncrement()
        {
            for (var i = 0; i < IterationsCount / 10; i++)
            {
                _intState += i;
                _intState += i;
                _intState += i;
                _intState += i;
                _intState += i;

                _intState += i;
                _intState += i;
                _intState += i;
                _intState += i;
                _intState += i;
            }

            Trace.WriteLine(_longState);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void EmptyStaticMethod()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private void EmptyMethod()
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        [SuppressMessage("Quality", "CA1801", Justification = "Microbenchmark")]
        [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Microbenchmark")]
        [SuppressMessage("ReSharper", "UnusedParameter.Local", Justification = "Microbenchmark")]
        private void EmptyMethod(int arg1)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        [SuppressMessage("Quality", "CA1801", Justification = "Microbenchmark")]
        [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Microbenchmark")]
        [SuppressMessage("ReSharper", "UnusedParameter.Local", Justification = "Microbenchmark")]
        private void EmptyMethod(int arg1, object arg2)
        {
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        [SuppressMessage("Quality", "CA1801", Justification = "Microbenchmark")]
        [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Microbenchmark")]
        [SuppressMessage("ReSharper", "UnusedParameter.Local", Justification = "Microbenchmark")]
        private object EmptyMethodRet(int arg1, object arg2)
        {
            return arg2;
        }

        private class DummyObject
        {
            // ReSharper disable once NotAccessedField.Local
            private static int _counter;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public DummyObject()
            {
                _counter++;
            }
        }

        private class SimpleDummy : IDummy
        {
            public void Test()
            {
                // Do nothing.
            }
        }
    }
}
