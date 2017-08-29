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
    }
}
