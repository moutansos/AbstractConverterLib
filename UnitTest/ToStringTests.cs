using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractConverterLib;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class ToStringTests
    {
        #region String To String Tests
        [TestMethod]
        public void StringToStringConverterObj()
        {
            string original = "This is a test string!";
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<string, string>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void StringToStringConverterObjSingleParam()
        {
            string original = "This is a test string!";
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<string>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion

        #region Bool To String Tests
        [TestMethod]
        public void BoolToStringConverterObj()
        {
            bool original = true;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<bool, string>(original);
            Assert.AreEqual(original.ToString(), converted);
        }

        [TestMethod]
        public void BoolToStringConverterObjSingleParam()
        {
            bool original = true;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<string>(original);
            Assert.AreEqual(original.ToString(), converted);
        }
        #endregion

        #region Byte To String Tests
        [TestMethod]
        public void ByteToStringConverterObj()
        {
            byte original = 34;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<byte, string>(original);
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void ByteToStringConverterObjSingleParam()
        {
            byte original = 34;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<string>(original);
            Assert.AreEqual(original + "", converted);
        }
        #endregion

        #region Int To String Tests
        [TestMethod]
        public void IntToStringConverterObj()
        {
            int original = -324342334;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<int, string>(original);
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void IntToStringConverterSingleParam()
        {
            int original = -324342334;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<string>(original);
            Assert.AreEqual(original + "", converted);
        }
        #endregion

        #region Float To String Tests
        [TestMethod]
        public void FloatToStringConverterObj()
        {
            float original = -1249999999999999999;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<float, string>(original);
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void FloatToStringConverterObjSingleParam()
        {
            float original = -1249999999999999999;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<string>(original);
            Assert.AreEqual(original + "", converted);
        }
        #endregion

        #region Double To String Tests
        [TestMethod]
        public void DoubleToStringConverterObj()
        {
            double original = -1249999999999999999;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<double, string>(original);
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void DoubleToStringConverterObjSingleParam()
        {
            double original = -1249999999999999999;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<string>(original);
            Assert.AreEqual(original + "", converted);
        }
        #endregion

        #region Decimal To String Tests
        [TestMethod]
        public void DecimalToStringConverterObj()
        {
            decimal original = -1249999999999999999;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<decimal, string>(original);
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void DecimalToStringConverterObjSingleParam()
        {
            decimal original = -1249999999999999999;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<string>(original);
            Assert.AreEqual(original + "", converted);
        }
        #endregion

        #region Sbyte To String Tests
        [TestMethod]
        public void SbyteToStringConverterObj()
        {
            sbyte original = -12;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<sbyte, string>(original);
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void SbyteToStringConverterObjSingleParam()
        {
            sbyte original = -12;
            AbstractConverter conv = new AbstractConverter();
            string converted = conv.Conv<sbyte, string>(original);
            Assert.AreEqual(original + "", converted);
        }
        #endregion

        //TODO: Rest of to string tests
    }
}
