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
            conv.Set<int, bool>(ConvToBool.IntToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<int, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void IntToBoolGreaterThanZeroTrueLessThanFalseConverterObjSingleParam()
        {
            int original = -345;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<int, bool>(ConvToBool.IntToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        //TODO: Test Exceptions
        #endregion

        #region Byte To Bool Tests
        [TestMethod]
        public void ByteToBoolOneOrZeroFalseIfOtherConverterObj()
        {
            byte original = 1;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<byte, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void ByteToBoolOneOrZeroFalseIfOtherConverterObjSingleParam()
        {
            byte original = -0;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void ByteToBoolOneOrZeroUnconvertabeIfOtherConverterObj()
        {
            byte original = 1;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<byte, bool>(ConvToBool.ByteToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<byte, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void ByteToBoolOneOrZeroUnconvertabeIfOtherConverterObjSingleParam()
        {
            byte original = 0;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<byte, bool>(ConvToBool.ByteToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        //TODO: Test Exceptions
        #endregion

        #region Float To Bool Tests
        [TestMethod]
        public void FloatToBoolOneOrZeroFalseIfOtherConverterObj()
        {
            float original = 1F;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<float, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void FloatToBoolOneOrZeroFalseIfOtherConverterObjSingleParam()
        {
            float original = -23.77F;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void FloatToBoolOneOrZeroUnconvertabeIfOtherConverterObj()
        {
            float original = 1F;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<float, bool>(ConvToBool.FloatToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<float, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void FloatToBoolOneOrZeroUnconvertabeIfOtherConverterObjSingleParam()
        {
            float original = 0F;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<float, bool>(ConvToBool.FloatToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void FloatToBoolGreaterThanZeroTrueLessThanFalseConverterObj()
        {
            float original = 1.532324F;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<float, bool>(ConvToBool.FloatToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<float, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void FloatToBoolGreaterThanZeroTrueLessThanFalseConverterObjSingleParam()
        {
            float original = -345.349203F;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<float, bool>(ConvToBool.FloatToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        //TODO: Test Exceptions
        #endregion
    }
}
