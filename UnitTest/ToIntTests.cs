﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractConverterLib;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class ToIntTests
    {
        #region Int To Int Tests
        [TestMethod]
        public void IntToIntConverterObj()
        {
            int original = 43234;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int, int>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void IntToIntConverterObjSingleParam()
        {
            int original = -343234;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion

        #region Bool To Int Tests
        [TestMethod]
        public void BoolToIntConverterObj()
        {
            bool original = true;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<bool, int>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void BoolToIntConverterObjSingleParam()
        {
            bool original = false;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(0, converted);
        }
        #endregion

        #region Byte To Int Tests
        [TestMethod]
        public void ByteToIntConverterObj()
        {
            byte original = 248;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<byte, int>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void ByteToIntConverterObjSingleParam()
        {
            byte original = 248;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion

        #region Float To Int Tests
        [TestMethod]
        public void FloatToIntRoundDownConverterObj()
        {
            float original = 1.3423F;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<float, int>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void FloatToIntRoundDownSingleParam()
        {
            float original = 1.3423F;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void FloatToIntRoundUpConverterObj()
        {
            float original = 1.3423F;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<float, int>(ConvToInt.FloatToIntRoundUp);
            int converted = conv.Conv<float, int>(original);
            Assert.AreEqual(2, converted);
        }

        [TestMethod]
        public void FloatToIntRoundUpSingleParam()
        {
            float original = 1.3423F;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<float, int>(ConvToInt.FloatToIntRoundUp);
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(2, converted);
        }
        #endregion

        #region Double To Int Tests
        [TestMethod]
        public void DoubleToIntRoundDownConverterObj()
        {
            double original = 1.3423;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<double, int>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void DoubleToIntRoundDownSingleParam()
        {
            double original = 1.3423;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void DoubleToIntRoundUpConverterObj()
        {
            double original = 1.3423;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<double, int>(ConvToInt.DoubleToIntRoundUp);
            int converted = conv.Conv<double, int>(original);
            Assert.AreEqual(2, converted);
        }

        [TestMethod]
        public void DoubleToIntRoundUpSingleParam()
        {
            double original = 1.3423;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<double, int>(ConvToInt.DoubleToIntRoundUp);
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(2, converted);
        }
        #endregion

        #region Decimal To Int Tests
        [TestMethod]
        public void DecimalToIntRoundDownConverterObj()
        {
            decimal original = 1.3423M;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<decimal, int>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void DecimalToIntRoundDownSingleParam()
        {
            decimal original = 1.3423M;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(1, converted);
        }

        [TestMethod]
        public void DecimalToIntRoundUpConverterObj()
        {
            decimal original = 1.3423M;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<decimal, int>(ConvToInt.DecimalToIntRoundUp);
            int converted = conv.Conv<decimal, int>(original);
            Assert.AreEqual(2, converted);
        }

        [TestMethod]
        public void DecimalToIntRoundUpSingleParam()
        {
            decimal original = 1.3423M;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<decimal, int>(ConvToInt.DecimalToIntRoundUp);
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(2, converted);
        }
        #endregion

        #region Sbyte To Int Tests
        [TestMethod]
        public void SbyteToIntConverterObj()
        {
            sbyte original = -28;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<sbyte, int>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void SbyteToIntConverterObjSingleParam()
        {
            sbyte original = -8;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion

        #region Long To Int Tests
        [TestMethod]
        public void LongToIntConverterObj()
        {
            long original = -28;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<long, int>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void LongToIntConverterObjSingleParam()
        {
            long original = -8;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(original, converted);
        }

        //TODO: Test Exceptions
        #endregion

        #region Short To Int Tests
        [TestMethod]
        public void ShortToIntConverterObj()
        {
            short original = -28;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<short, int>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void ShortToIntConverterObjSingleParam()
        {
            short original = -8;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion

        #region Uint To Int Tests
        [TestMethod]
        public void UintToIntConverterObj()
        {
            uint original = 28;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<uint, int>(original);
            Assert.AreEqual(28, converted);
        }

        [TestMethod]
        public void UintToIntConverterObjSingleParam()
        {
            uint original = 832;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(832, converted);
        }

        //TODO: Test Exceptions
        #endregion

        #region Ulong To Int Tests
        [TestMethod]
        public void UlongToIntConverterObj()
        {
            ulong original = 2823434;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<ulong, int>(original);
            Assert.AreEqual(2823434, converted);
        }

        [TestMethod]
        public void UlongToIntConverterObjSingleParam()
        {
            ulong original = 832438;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(832438, converted);
        }

        //TODO: Test Exceptions
        #endregion

        #region Ushort To Int Tests
        [TestMethod]
        public void UshortToIntConverterObj()
        {
            ushort original = 28234;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<ushort, int>(original);
            Assert.AreEqual(28234, converted);
        }

        [TestMethod]
        public void UshortToIntConverterObjSingleParam()
        {
            ushort original = 8324;
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(8324, converted);
        }
        #endregion

        #region Char To Int Tests
        [TestMethod]
        public void CharToIntRawConverterObj()
        {
            char original = 'a';
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<char, int>(original);
            Assert.AreEqual(97, converted);
        }

        [TestMethod]
        public void CharToIntRawConverterObjSingleParam()
        {
            char original = '1';
            AbstractConverter conv = new AbstractConverter();
            int converted = conv.Conv<int>(original);
            Assert.AreEqual(49, converted);
        }
        #endregion
    }
}