using System;
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
    }
}
