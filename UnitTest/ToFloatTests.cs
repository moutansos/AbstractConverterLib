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
        public void IntToIntConverterObjSingleParam()
        {
            float original = -343234.5324F;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion
    }
}
