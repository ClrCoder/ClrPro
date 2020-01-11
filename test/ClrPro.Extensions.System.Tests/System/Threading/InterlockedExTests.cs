// Copyright (c) ClrCoder community. All Rights Reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace System.Threading
{
    using System.Diagnostics;
    using Xunit;
    using Xunit.Abstractions;

    public class InterlockedExTests
    {
        private readonly ITestOutputHelper _testOutput;
        private double _doubleState;
        private float _floatState;

        private IntPtr _intPtrState = IntPtr.Zero;
        private int _intState;
        private long _longState;

        private object _objectState = "abc";

        private string _stringState = "abc";

        public InterlockedExTests(ITestOutputHelper testOutput)
        {
            _testOutput = testOutput;
        }

        [Trait("Category", "AsmGenTest")]
        [Fact]
        public void AsmGenCompareExchangeIntTest()
        {
            Debugger.Break();
            var observedValue = _intState;
            int updatedValue;
            do
            {
                updatedValue = observedValue + 1;
            }
            while (!InterlockedEx.CompareExchange(ref _intState, updatedValue, ref observedValue));
        }

        [Trait("Category", "AsmGenTest")]
        [Fact]
        public void AsmGenCompareExchangeLongTest()
        {
            Debugger.Break();
            var observedValue = _longState;
            long updatedValue;
            do
            {
                updatedValue = observedValue + 1;
            }
            while (!InterlockedEx.CompareExchange(ref _longState, updatedValue, ref observedValue));
        }

        [Trait("Category", "AsmGenTest")]
        [Fact]
        public void AsmGenCompareExchangeDoubleTest()
        {
            // Avoid the double interlocked, it's very slow.
            Debugger.Break();
            var observedValue = _doubleState;
            double updatedValue;
            do
            {
                updatedValue = observedValue + 1.0;
            }
            while (!InterlockedEx.CompareExchange(ref _doubleState, updatedValue, ref observedValue));
        }

        [Trait("Category", "AsmGenTest")]
        [Fact]
        public void AsmGenCompareExchangeFloatTest()
        {
            Debugger.Break();
            var observedValue = _floatState;
            float updatedValue;
            do
            {
                updatedValue = observedValue + 1.0F;
            }
            while (!InterlockedEx.CompareExchange(ref _floatState, updatedValue, ref observedValue));
        }

        [Trait("Category", "AsmGenTest")]
        [Fact]
        public void AsmGenCompareExchangeObjectTest()
        {
            Debugger.Break();
            var observedValue = _objectState;
            object updatedValue;
            do
            {
                updatedValue = (string)observedValue + "a";
            }
            while (!InterlockedEx.CompareExchange(ref _objectState, updatedValue, ref observedValue));

            _testOutput.WriteLine(_objectState.ToString());
        }

        [Trait("Category", "AsmGenTest")]
        [Fact]
        public void AsmGenCompareExchangeTemplateTest()
        {
            Debugger.Break();
            var observedValue = _stringState;
            string updatedValue;
            do
            {
                updatedValue = observedValue + "a";
            }
            while (!InterlockedEx.CompareExchange(ref _stringState, updatedValue, ref observedValue));
        }

        [Trait("Category", "AsmGenTest")]
        [Fact]
        public void AsmGenCompareExchangeIntPtrTest()
        {
            Debugger.Break();
            var observedValue = _intPtrState;
            IntPtr updatedValue;
            do
            {
                updatedValue = observedValue + 0x16;
            }
            while (!InterlockedEx.CompareExchange(ref _intPtrState, updatedValue, ref observedValue));
        }
    }
}
