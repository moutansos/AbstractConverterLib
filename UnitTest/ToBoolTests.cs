using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractConverterLib;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class ToBoolTests
    {
        #region Bool To Bool Tests
        [TestMethod]
        public void BoolToBoolConverterObj()
        {
            bool original = true;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<bool, bool>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void BoolToBoolConverterObjSingleParam()
        {
            bool original = true;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void BoolToBoolToggleConverterObj()
        {
            bool original = true;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<bool, bool>(ConvToBool.BoolToBoolToggle);
            bool converted = conv.Conv<bool, bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void BoolToBoolTobbleConverterObjSingleParam()
        {
            bool original = true;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<bool, bool>(ConvToBool.BoolToBoolToggle);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }
        #endregion
    }
}
