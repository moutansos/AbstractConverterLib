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
            double original = 1.3423F;
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
    }
}
 