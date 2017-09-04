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
        
        #region Bool To Float Tests
        [TestMethod]
        public void BoolToFloatConverterObj()
        {
            bool original = true;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<bool, float>(original);
            Assert.AreEqual(1F, converted);
        }

        [TestMethod]
        public void BoolToFloatConverterObjSingleParam()
        {
            bool original = false;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(0F, converted);
        }
        #endregion

        #region Byte To Float Tests
        [TestMethod]
        public void ByteToFloatConverterObj()
        {
            byte original = 43;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<byte, float>(original);
            Assert.AreEqual(43F, converted);
        }

        [TestMethod]
        public void ByteToFloatConverterObjSingleParam()
        {
            byte original = 234;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(234F, converted);
        }
        #endregion

        #region Int To Float Tests
        [TestMethod]
        public void IntToFloatConverterObj()
        {
            int original = 232423905;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<int, float>(original);
            Assert.AreEqual(232423905F, converted);
        }

        [TestMethod]
        public void IntToFloatConverterObjSingleParam()
        {
            int original = -232423905;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(-232423905F, converted);
        }
        #endregion

        #region Double To Float Tests
        [TestMethod]
        public void DoubleToFloatDefaultIfUnconvertableConverterObj()
        {
            double original = 232423905D;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<double, float>(original);
            Assert.AreEqual(232423905F, converted);
        }

        [TestMethod]
        public void DoubleToFloatDefaultIfUnconvertableConverterObjSingleParam()
        {
            double original = -23242390532432444453234324324323423232442D;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(0F, converted);
        }

        [TestMethod]
        public void DoubelToFloatExceptionIfUnconvertableConverterObj()
        {
            double original = 232423905D;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<double, float>(ConvToFloat.DoubleToFloatExceptionIfUnconvertable);
            float converted = conv.Conv<double, float>(original);
            Assert.AreEqual(232423905F, converted);
        }

        [TestMethod]
        public void DoubleToFloatExceptionIfUnconvertableConverterObjSingleParam()
        {
            double original = -2324239053243244444D;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<double, float>(ConvToFloat.DoubleToFloatExceptionIfUnconvertable);
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(-2324239053243244444F, converted);
        }

        //TODO: Test exceptions
        #endregion

        #region Decimal To Float Tests
        [TestMethod]
        public void DecimalToFloatDefaultIfUnconvertableConverterObj()
        {
            decimal original = 93242390532233323432.34333322234234234333232342334M;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<decimal, float>(original);
            Assert.AreEqual(93242390532233323432.34333322234234234333232342334F, converted);
        }

        [TestMethod]
        public void DecimalToFloatDefaultIfUnconvertableConverterObjSingleParam()
        {
            decimal original = -232423905324324M;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(-232423905324324F, converted);
        }

        [TestMethod]
        public void DecimalToFloatExceptionIfUnconvertableConverterObj()
        {
            decimal original = 232423905M;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<decimal, float>(ConvToFloat.DecimalToFloatExceptionIfUnconvertable);
            float converted = conv.Conv<decimal, float>(original);
            Assert.AreEqual(232423905F, converted);
        }

        [TestMethod]
        public void DecimalToFloatExceptionIfUnconvertableConverterObjSingleParam()
        {
            decimal original = -2324239053243244444M;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<decimal, float>(ConvToFloat.DecimalToFloatExceptionIfUnconvertable);
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(-2324239053243244444F, converted);
        }

        //TODO: Test exceptions
        #endregion

        #region Sbyte To Float Tests
        [TestMethod]
        public void SbyteToFloatConverterObj()
        {
            sbyte original = -43;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<sbyte, float>(original);
            Assert.AreEqual(-43F, converted);
        }

        [TestMethod]
        public void SbyteToFloatConverterObjSingleParam()
        {
            sbyte original = 56;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(56F, converted);
        }
        #endregion

        #region Long To Float Tests
        [TestMethod]
        public void LongToFloatConverterObj()
        {
            long original = -4332444444444444323;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<long, float>(original);
            Assert.AreEqual(-4332444444444444323F, converted);
        }

        [TestMethod]
        public void LongToFloatConverterObjSingleParam()
        {
            long original = 56;
            AbstractConverter conv = new AbstractConverter();
            float converted = conv.Conv<float>(original);
            Assert.AreEqual(56F, converted);
        }
        #endregion
    }
}