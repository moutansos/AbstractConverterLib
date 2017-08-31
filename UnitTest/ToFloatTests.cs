using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractConverterLib;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class ToFloatTests
    {
        #region Float To Float Tests
        [TestMethod]
        public void FloatToFloatConverterObj()
        {
            float original = 43234.53434F;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float, float>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void FloatToFloatConverterObjSingleParam()
        {
            float original = -343234.5324F;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion

        #region String To Float Tests
        [TestMethod]
        public void StringToFloatZeroIfEmptyOrUnconvertableConverterObj()
        {
            string original = "43234.53434F    ";
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<string, float>(original);
            Assert.AreEqual(43234.53434F, converted);
        }

        [TestMethod]
        public void StringTfoFloatZeroIfEmptyOrUnconvertableConverterObjSingleParam()
        {
            string original = "     -343234.5324";
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(-343234.5324F, converted);
        }

        [TestMethod]
        public void StringToFloatExceptionIfUnconvertablConverterObj()
        {
            string original = "43234.53434F    ";
            AbstractConverter conv = new AbstractConverter();
            conv.Set<string, float>(ConvToFloat.StringToFloatExceptionIfUnconvertable);
            float converted = conv.Conv<string, float>(original);
            Assert.AreEqual(43234.53434F, converted);
        }

        [TestMethod]
        public void StringTfoFloatExceptionIfUnconvertablConverterObjSingleParam()
        {
            string original = "     -343234.5324";
            AbstractConverter conv = new AbstractConverter();
            conv.Set<string, float>(ConvToFloat.StringToFloatExceptionIfUnconvertable);
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(-343234.5324F, converted);
        }

        //TODO: Test Exceptions
        #endregion
        
        #region Bool To Float Tests
        [TestMethod]
        public void BoolToFloatConverterObj()
        {
            bool original = true;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<bool, float>(original);
            Assert.AreEqual(1F, converted);
        }

        [TestMethod]
        public void BoolToFloatConverterObjSingleParam()
        {
            bool original = false;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(0F, converted);
        }
        #endregion

        #region Byte To Float Tests
        [TestMethod]
        public void ByteToFloatConverterObj()
        {
            byte original = 43;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<byte, float>(original);
            Assert.AreEqual(43F, converted);
        }

        [TestMethod]
        public void ByteToFloatConverterObjSingleParam()
        {
            byte original = 234;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(234F, converted);
        }
        #endregion

        #region Int To Float Tests
        [TestMethod]
        public void IntToFloatConverterObj()
        {
            int original = 232423905;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<int, float>(original);
            Assert.AreEqual(232423905F, converted);
        }

        [TestMethod]
        public void IntToFloatConverterObjSingleParam()
        {
            int original = -232423905;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(-232423905F, converted);
        }
        #endregion
    }
}