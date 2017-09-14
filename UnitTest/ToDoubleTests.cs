using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractConverterLib;

namespace UnitTest
{
    [TestClass]
    public class ToDoubleTests
    {
        #region Double To Double Tests
        [TestMethod]
        public void DoubleToDoubleConverterObj()
        {
            double original = 43234.534334323243245434354D;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double, double>(original);
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void DoubleToDoubleConverterObjSingleParam()
        {
            double original = -343234.5324D;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(original, converted);
        }
        #endregion

        #region String To Double Tests
        [TestMethod]
        public void StringToDoubleZeroIfEmptyOrUnconvertableConverterObj()
        {
            string original = "43234.53432342342344D    ";
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<string, double>(original);
            Assert.AreEqual(43234.53432342342344D, converted);
        }

        [TestMethod]
        public void StringToDoubleZeroIfEmptyOrUnconvertableConverterObjSingleParam()
        {
            string original = "     -343234.5324";
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(-343234.5324D, converted);
        }

        [TestMethod]
        public void StringToDoubleExceptionIfUnconvertablConverterObj()
        {
            string original = "43234.53434D    ";
            AbstractConverter conv = new AbstractConverter();
            conv.Set<string, double>(ConvToDouble.StringToDoubleExceptionIfUnconvertable);
            double converted = conv.Conv<string, double>(original);
            Assert.AreEqual(43234.53434D, converted);
        }

        [TestMethod]
        public void StringToDoubleExceptionIfUnconvertablConverterObjSingleParam()
        {
            string original = "     -343234.5324";
            AbstractConverter conv = new AbstractConverter();
            conv.Set<string, double>(ConvToDouble.StringToDoubleExceptionIfUnconvertable);
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(-343234.5324D, converted);
        }

        //TODO: Test Exceptions
        #endregion
        
        #region Bool To Double Tests
        [TestMethod]
        public void BoolToDoubleConverterObj()
        {
            bool original = true;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<bool, double>(original);
            Assert.AreEqual(1D, converted);
        }

        [TestMethod]
        public void BoolToDoubleConverterObjSingleParam()
        {
            bool original = false;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(0D, converted);
        }
        #endregion

        #region Byte To Float Tests
        [TestMethod]
        public void ByteToDoubleConverterObj()
        {
            byte original = 43;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<byte, double>(original);
            Assert.AreEqual(43D, converted);
        }

        [TestMethod]
        public void ByteToDoubleConverterObjSingleParam()
        {
            byte original = 234;
            AbstractConverter conv = new AbstractConverter();
            double converted = conv.Conv<double>(original);
            Assert.AreEqual(234D, converted);
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

        #region Long To Float Tests
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
