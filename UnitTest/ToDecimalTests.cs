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

        #region Int To Double Tests
        [TestMethod]
        public void IntToDoubleConverterObj()
        {
            int original = 232423905;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<int, double>(original);
            Assert.AreEqual(232423905D, converted);
        }

        [TestMethod]
        public void IntToDoubleConverterObjSingleParam()
        {
            int original = -232423905;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(-232423905D, converted);
        }
        #endregion

        #region Float To Double Tests
        [TestMethod]
        public void FloatToDoubleConverterObj()
        {
            float original = 23F;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<float, double>(original);
            Assert.AreEqual(23D, converted);
        }

        [TestMethod]
        public void FloatToDoubleConverterObjSingleParam()
        {
            float original = -23F;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(-23D, converted);
        }
        #endregion

        #region Decimal To Double Tests
        [TestMethod]
        public void DecimalToDoubleDefaultIfUnconvertableConverterObj()
        {
            decimal original = 10M;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<decimal, double>(original);
            Assert.AreEqual(10D, converted);
        }

        [TestMethod]
        public void DecimalToDoubleDefaultIfUnconvertableConverterObjSingleParam()
        {
            decimal original = -232423905324324M;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(-232423905324324D, converted);
        }

        [TestMethod]
        public void DecimalToDoubleExceptionIfUnconvertableConverterObj()
        {
            decimal original = 232423905M;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<decimal, double>(ConvToDouble.DecimalToDoubleExceptionIfUnconvertable);
            double converted = conv.Conv<decimal, double>(original);
            Assert.AreEqual(232423905D, converted);
        }

        [TestMethod]
        public void DecimalToDoubleExceptionIfUnconvertableConverterObjSingleParam()
        {
            decimal original = -2324239053243244444M;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<decimal, double>(ConvToDouble.DecimalToDoubleExceptionIfUnconvertable);
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(-2324239053243244444D, converted);
        }

        //TODO: Test exceptions
        #endregion

        #region Sbyte To Double Tests
        [TestMethod]
        public void SbyteToDoubleConverterObj()
        {
            sbyte original = -43;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<sbyte, double>(original);
            Assert.AreEqual(-43F, converted);
        }

        [TestMethod]
        public void SbyteToDoubleConverterObjSingleParam()
        {
            sbyte original = 56;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(56D, converted);
        }
        #endregion

        #region Long To Double Tests
        [TestMethod]
        public void LongToDoubleConverterObj()
        {
            long original = -4332444444444444323;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<long, double>(original);
            Assert.AreEqual(-4332444444444444323D, converted);
        }

        [TestMethod]
        public void LongToDoubleConverterObjSingleParam()
        {
            long original = 56;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(56D, converted);
        }
        #endregion

        #region Short To Double Tests
        [TestMethod]
        public void ShortToDoubleConverterObj()
        {
            short original = -4332;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<short, double>(original);
            Assert.AreEqual(-4332D, converted);
        }

        [TestMethod]
        public void ShortToDoubleConverterObjSingleParam()
        {
            short original = 56;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(56F, converted);
        }
        #endregion

        #region Uint To Double Tests
        [TestMethod]
        public void UintToDoubleConverterObj()
        {
            uint original = 433232222;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<uint, double>(original);
            Assert.AreEqual(433232222D, converted);
        }

        [TestMethod]
        public void UintToDoubleConverterObjSingleParam()
        {
            uint original = 56;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(56D, converted);
        }
        #endregion

        #region Ulong To Double Tests
        [TestMethod]
        public void UlongToDoubleConverterObj()
        {
            ulong original = 4332444444444444323;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<ulong, double>(original);
            Assert.AreEqual(4332444444444444323D, converted);
        }

        [TestMethod]
        public void UlongToDoubleConverterObjSingleParam()
        {
            ulong original = 56;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(56D, converted);
        }
        #endregion

        #region Ushort To Double Tests
        [TestMethod]
        public void UshortToDoubleConverterObj()
        {
            ushort original = 43324;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<ushort, double>(original);
            Assert.AreEqual(43324D, converted);
        }

        [TestMethod]
        public void UshortToDoubleConverterObjSingleParam()
        {
            ushort original = 56;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(56D, converted);
        }
        #endregion

        #region Char To Double Tests
        [TestMethod]
        public void CharToDoubleRawConverterObj()
        {
            char original = 'a';
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<char, double>(original);
            Assert.AreEqual(97D, converted);
        }

        [TestMethod]
        public void CharToDoubleRawConverterObjSingleParam()
        {
            char original = '1';
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(49D, converted);
        }
        #endregion
    }
}
