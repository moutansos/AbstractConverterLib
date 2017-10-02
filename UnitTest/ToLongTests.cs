using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractConverterLib;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class ToLongTests
    {
        #region Long To Long Tests
        [TestMethod]
        public void LongToLongConverterObj()
        {
            long original = 43234;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long, long>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void LongToLongConverterObjSingleParam()
        {
            long original = -343234;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion

        #region Bool To Long Tests
        [TestMethod]
        public void BoolToLongConverterObj()
        {
            bool original = true;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<bool, long>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void BoolToLongConverterObjSingleParam()
        {
            bool original = false;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(0, converted);
        }
        #endregion

        #region Byte To Long Tests
        [TestMethod]
        public void ByteToLongConverterObj()
        {
            byte original = 248;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<byte, long>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void ByteToLongConverterObjSingleParam()
        {
            byte original = 248;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion

        #region Float To Long Tests
        [TestMethod]
        public void FloatToLongRoundDownConverterObj()
        {
            float original = 1.3423F;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<float, long>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void FloatToLongRoundDownSingleParam()
        {
            float original = 1.3423F;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void FloatToLongRoundUpConverterObj()
        {
            float original = 1.3423F;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<float, long>(ConvToLong.FloatToLongRoundUp);
            long converted = conv.Conv<float, long>(original);
            Assert.AreEqual(2, converted);
        }

        [TestMethod]
        public void FloatToLongRoundUpSingleParam()
        {
            float original = 1.3423F;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<float, long>(ConvToLong.FloatToLongRoundUp);
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(2, converted);
        }
        #endregion

        #region Double To Long Tests
        [TestMethod]
        public void DoubleToLongRoundDownConverterObj()
        {
            double original = 1.3423;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<double, long>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void DoubleToLongRoundDownSingleParam()
        {
            double original = 1.3423;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void DoubleToLongRoundUpConverterObj()
        {
            double original = 1.3423;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<double, long>(ConvToLong.DoubleToLongRoundUp);
            long converted = conv.Conv<double, long>(original);
            Assert.AreEqual(2, converted);
        }

        [TestMethod]
        public void DoubleToLongRoundUpSingleParam()
        {
            double original = 1.3423;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<double, long>(ConvToLong.DoubleToLongRoundUp);
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(2, converted);
        }
        #endregion

        #region Decimal To Long Tests
        [TestMethod]
        public void DecimalToLongRoundDownConverterObj()
        {
            decimal original = 1.3423M;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<decimal, long>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void DecimalToLongRoundDownSingleParam()
        {
            decimal original = 1.3423M;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void DecimalToLongRoundUpConverterObj()
        {
            decimal original = 1.3423M;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<decimal, long>(ConvToLong.DecimalToLongRoundUp);
            long converted = conv.Conv<decimal, long>(original);
            Assert.AreEqual(2, converted);
        }

        [TestMethod]
        public void DecimalToLongRoundUpSingleParam()
        {
            decimal original = 1.3423M;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<decimal, long>(ConvToLong.DecimalToLongRoundUp);
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(2, converted);
        }
        #endregion

        #region Sbyte To Long Tests
        [TestMethod]
        public void SbyteToLongConverterObj()
        {
            sbyte original = -28;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<sbyte, long>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void SbyteToLongConverterObjSingleParam()
        {
            sbyte original = -8;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion

        #region Int To Long Tests
        [TestMethod]
        public void IntToLongConverterObj()
        {
            int original = -28;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<int, long>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void IntToLongConverterObjSingleParam()
        {
            int original = -8;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion

        #region Short To Long Tests
        [TestMethod]
        public void ShortToLongConverterObj()
        {
            short original = -28;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<short, long>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void ShortToLongConverterObjSingleParam()
        {
            short original = -8;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion

        #region Uint To Long Tests
        [TestMethod]
        public void UintToLongConverterObj()
        {
            uint original = 28;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<uint, long>(original);
            Assert.AreEqual(28, converted);
        }

        [TestMethod]
        public void UintToLongConverterObjSingleParam()
        {
            uint original = 832;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(832, converted);
        }

        //TODO: Test Exceptions
        #endregion

        #region Ulong To Long Tests
        [TestMethod]
        public void UlongToLongConverterObj()
        {
            ulong original = 2823434;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<ulong, long>(original);
            Assert.AreEqual(2823434, converted);
        }

        [TestMethod]
        public void UlongToLongConverterObjSingleParam()
        {
            ulong original = 832438;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(832438, converted);
        }

        //TODO: Test Exceptions
        #endregion

        #region Ushort To Long Tests
        [TestMethod]
        public void UshortToLongConverterObj()
        {
            ushort original = 28234;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<ushort, long>(original);
            Assert.AreEqual(28234, converted);
        }

        [TestMethod]
        public void UshortToLongConverterObjSingleParam()
        {
            ushort original = 8324;
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(8324, converted);
        }
        #endregion

        #region Char To Long Tests
        [TestMethod]
        public void CharToLongRawConverterObj()
        {
            char original = 'a';
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<char, long>(original);
            Assert.AreEqual(97, converted);
        }

        [TestMethod]
        public void CharToLongRawConverterObjSingleParam()
        {
            char original = '1';
            AbstractConverter conv = new AbstractConverter();
            long converted = conv.Conv<long>(original);
            Assert.AreEqual(49, converted);
        }
        #endregion
    }
}