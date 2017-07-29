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

        #region Int To Bool Tests
        [TestMethod]
        public void IntToBoolOneOrZeroFalseIfOtherConverterObj()
        {
            int original = 1;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<int, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void IntToBoolOneOrZeroFalseIfOtherConverterObjSingleParam()
        {
            int original = -23;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void IntToBoolOneOrZeroUnconvertabeIfOtherConverterObj()
        {
            int original = 1;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<int, bool>(ConvToBool.IntToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<int, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void IntToBoolOneOrZeroUnconvertabeIfOtherConverterObjSingleParam()
        {
            int original = 0;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<int, bool>(ConvToBool.IntToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void IntToBoolGreaterThanZeroTrueLessThanFalseConverterObj()
        {
            int original = 1;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<int, bool>(ConvToBool.IntToBoolOneOrZeroFalseIfOther);
            bool converted = conv.Conv<int, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void IntToBoolGreaterThanZeroTrueLessThanFalseConverterObjSingleParam()
        {
            int original = -345;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<int, bool>(ConvToBool.IntToBoolOneOrZeroFalseIfOther);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        //TODO: Test Exceptions
        #endregion
    }
}
