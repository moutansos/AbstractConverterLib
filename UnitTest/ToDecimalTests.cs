using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractConverterLib;

namespace UnitTest
{
    [TestClass]
    public class ToDecimalTests
    {
        #region Decimal To Decimal Tests
        [TestMethod]
        public void DecimalToDecimalConverterObj()
        {
            decimal original = 43234.534334323243245434354m;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal, decimal>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void DecimalToDecimalConverterObjSingleParam()
        {
            decimal original = -343234.5324m;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion

        #region String To Decimal Tests
        [TestMethod]
        public void StringToDecimalZeroIfEmptyOrUnconvertableConverterObj()
        {
            string original = "43234.53432342342344m    ";
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<string, decimal>(original);
            Assert.AreEqual(43234.53432342342344m, converted);
        }

        [TestMethod]
        public void StringToDecimalZeroIfEmptyOrUnconvertableConverterObjSingleParam()
        {
            string original = "     -343234.5324";
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(-343234.5324m, converted);
        }

        [TestMethod]
        public void StringToDecimalExceptionIfUnconvertablConverterObj()
        {
            string original = "43234.53434m    ";
            AbstractConverter conv = new AbstractConverter();
            conv.Set<string, decimal>(ConvToDecimal.StringToDecimalExceptionIfUnconvertable);
            decimal converted = conv.Conv<string, decimal>(original);
            Assert.AreEqual(43234.53434m, converted);
        }

        [TestMethod]
        public void StringToDecimalExceptionIfUnconvertablConverterObjSingleParam()
        {
            string original = "     -343234.5324";
            AbstractConverter conv = new AbstractConverter();
            conv.Set<string, decimal>(ConvToDecimal.StringToDecimalExceptionIfUnconvertable);
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(-343234.5324m, converted);
        }

        //TODO: Test Exceptions
        #endregion
        
        #region Bool To Decimal Tests
        [TestMethod]
        public void BoolToDecimalConverterObj()
        {
            bool original = true;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<bool, decimal>(original);
            Assert.AreEqual(1m, converted);
        }

        [TestMethod]
        public void BoolToDecimalConverterObjSingleParam()
        {
            bool original = false;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(0m, converted);
        }
        #endregion

        #region Byte To Decimal Tests
        [TestMethod]
        public void ByteToDecimalConverterObj()
        {
            byte original = 43;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<byte, decimal>(original);
            Assert.AreEqual(43m, converted);
        }

        [TestMethod]
        public void ByteToDecimalConverterObjSingleParam()
        {
            byte original = 234;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(234m, converted);
        }
        #endregion

        #region Int To Decimal Tests
        [TestMethod]
        public void IntToDecimalConverterObj()
        {
            int original = 232423905;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<int, decimal>(original);
            Assert.AreEqual(232423905m, converted);
        }

        [TestMethod]
        public void IntToDecimalConverterObjSingleParam()
        {
            int original = -232423905;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(-232423905m, converted);
        }
        #endregion

        #region Float To Decimal Tests
        [TestMethod]
        public void FloatToDecimalConverterObj()
        {
            float original = 23F;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<float, decimal>(original);
            Assert.AreEqual(23m, converted);
        }

        [TestMethod]
        public void FloatToDecimalConverterObjSingleParam()
        {
            float original = -23F;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(-23m, converted);
        }
        #endregion

        #region Double To Decimal Tests
        [TestMethod]
        public void DoubleToDecimalConverterObj()
        {
            double original = 10D;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<double, decimal>(original);
            Assert.AreEqual(10m, converted);
        }

        [TestMethod]
        public void DoubleToDecimalConverterObjSingleParam()
        {
            double original = -232423905324324D;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(-232423905324324m, converted);
        }
        #endregion

        #region Sbyte To Decimal Tests
        [TestMethod]
        public void SbyteToDecimalConverterObj()
        {
            sbyte original = -43;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<sbyte, decimal>(original);
            Assert.AreEqual(-43m, converted);
        }

        [TestMethod]
        public void SbyteToDecimalConverterObjSingleParam()
        {
            sbyte original = 56;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(56m, converted);
        }
        #endregion

        #region Long To Decimal Tests
        [TestMethod]
        public void LongToDecimalConverterObj()
        {
            long original = -4332444444444444323;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<long, decimal>(original);
            Assert.AreEqual(-4332444444444444323m, converted);
        }

        [TestMethod]
        public void LongToDecimalConverterObjSingleParam()
        {
            long original = 56;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(56m, converted);
        }
        #endregion

        #region Short To Decimal Tests
        [TestMethod]
        public void ShortToDecimalConverterObj()
        {
            short original = -4332;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<short, decimal>(original);
            Assert.AreEqual(-4332m, converted);
        }

        [TestMethod]
        public void ShortToDecimalConverterObjSingleParam()
        {
            short original = 56;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(56m, converted);
        }
        #endregion

        #region Uint To Decimal Tests
        [TestMethod]
        public void UintToDecimalConverterObj()
        {
            uint original = 433232222;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<uint, decimal>(original);
            Assert.AreEqual(433232222m, converted);
        }

        [TestMethod]
        public void UintToDecimalConverterObjSingleParam()
        {
            uint original = 56;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(56m, converted);
        }
        #endregion

        #region Ulong To Decimal Tests
        [TestMethod]
        public void UlongToDecimalConverterObj()
        {
            ulong original = 4332444444444444323;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<ulong, decimal>(original);
            Assert.AreEqual(4332444444444444323m, converted);
        }

        [TestMethod]
        public void UlongToDecimalConverterObjSingleParam()
        {
            ulong original = 56;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(56m, converted);
        }
        #endregion

        #region Ushort To Decimal Tests
        [TestMethod]
        public void UshortToDecimalConverterObj()
        {
            ushort original = 43324;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<ushort, decimal>(original);
            Assert.AreEqual(43324m, converted);
        }

        [TestMethod]
        public void UshortToDecimalConverterObjSingleParam()
        {
            ushort original = 56;
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(56m, converted);
        }
        #endregion

        #region Char To Decimal Tests
        [TestMethod]
        public void CharToDecimalRawConverterObj()
        {
            char original = 'a';
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<char, decimal>(original);
            Assert.AreEqual(97m, converted);
        }

        [TestMethod]
        public void CharToDecimalRawConverterObjSingleParam()
        {
            char original = '1';
            AbstractConverter conv = new AbstractConverter();
            decimal converted = conv.Conv<decimal>(original);
            Assert.AreEqual(49m, converted);
        }
        #endregion
    }
}
