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
            byte original = 0;
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
        
        #region Double To Bool Tests
        [TestMethod]
        public void DoubleToBoolOneOrZeroFalseIfOtherConverterObj()
        {
            double original = 1D;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<double, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void DoubleToBoolOneOrZeroFalseIfOtherConverterObjSingleParam()
        {
            double original = -23.77D;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void DoubleToBoolOneOrZeroUnconvertabeIfOtherConverterObj()
        {
            double original = 1D;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<double, bool>(ConvToBool.DoubleToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<double, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void DoubleToBoolOneOrZeroUnconvertabeIfOtherConverterObjSingleParam()
        {
            double original = 0D;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<double, bool>(ConvToBool.DoubleToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void DoubleToBoolGreaterThanZeroTrueLessThanFalseConverterObj()
        {
            double original = 1.532324D;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<double, bool>(ConvToBool.DoubleToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<double, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void DoubleToBoolGreaterThanZeroTrueLessThanFalseConverterObjSingleParam()
        {
            double original = -345.349203D;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<double, bool>(ConvToBool.DoubleToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        //TODO: Test Exceptions
        #endregion
        
        #region Decimal To Bool Tests
        [TestMethod]
        public void DecimalToBoolOneOrZeroFalseIfOtherConverterObj()
        {
            decimal original = 1m;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<decimal, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void DecimalToBoolOneOrZeroFalseIfOtherConverterObjSingleParam()
        {
            decimal original = -232343242342342342234234234.77m;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void DecimalToBoolOneOrZeroUnconvertabeIfOtherConverterObj()
        {
            decimal original = 1m;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<decimal, bool>(ConvToBool.DecimalToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<decimal, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void DecimalToBoolOneOrZeroUnconvertabeIfOtherConverterObjSingleParam()
        {
            decimal original = 0m;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<decimal, bool>(ConvToBool.DecimalToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void DecimalToBoolGreaterThanZeroTrueLessThanFalseConverterObj()
        {
            decimal original = 1.532324m;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<decimal, bool>(ConvToBool.DecimalToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<decimal, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void DecimalToBoolGreaterThanZeroTrueLessThanFalseConverterObjSingleParam()
        {
            decimal original = -345.34920724837423984723984723m;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<decimal, bool>(ConvToBool.DecimalToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        //TODO: Test Exceptions
        #endregion
        
        #region Sbyte To Bool Tests
        [TestMethod]
        public void SbyteToBoolOneOrZeroFalseIfOtherConverterObj()
        {
            sbyte original = 1; //TODO: Change to sbyte literal
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<sbyte, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void SbyteToBoolOneOrZeroFalseIfOtherConverterObjSingleParam()
        {
            sbyte original = -23; //TODO: Change to sbyte literal
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void SbyteToBoolOneOrZeroUnconvertabeIfOtherConverterObj()
        {
            sbyte original = 1; //TODO: Change to sbyte literal
            AbstractConverter conv = new AbstractConverter();
            conv.Set<sbyte, bool>(ConvToBool.SbyteToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<sbyte, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void SbyteToBoolOneOrZeroUnconvertabeIfOtherConverterObjSingleParam()
        {
            sbyte original = 0; //TODO: Change to sbyte literal
            AbstractConverter conv = new AbstractConverter();
            conv.Set<sbyte, bool>(ConvToBool.SbyteToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void SbyteToBoolGreaterThanZeroTrueLessThanFalseConverterObj()
        {
            sbyte original = 1; //TODO: Change to sbyte literal
            AbstractConverter conv = new AbstractConverter();
            conv.Set<sbyte, bool>(ConvToBool.SbyteToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<sbyte, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void SbyteToBoolGreaterThanZeroTrueLessThanFalseConverterObjSingleParam()
        {
            sbyte original = -34; //TODO: Change to sbyte literal
            AbstractConverter conv = new AbstractConverter();
            conv.Set<sbyte, bool>(ConvToBool.SbyteToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        //TODO: Test Exceptions
        #endregion

        #region Long To Bool Tests
        [TestMethod]
        public void LongToBoolOneOrZeroFalseIfOtherConverterObj()
        {
            long original = 1;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<long, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void LongToBoolOneOrZeroFalseIfOtherConverterObjSingleParam()
        {
            long original = -23;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void LongToBoolOneOrZeroUnconvertabeIfOtherConverterObj()
        {
            long original = 1;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<long, bool>(ConvToBool.LongToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<long, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void LongToBoolOneOrZeroUnconvertabeIfOtherConverterObjSingleParam()
        {
            long original = 0;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<long, bool>(ConvToBool.LongToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void LongToBoolGreaterThanZeroTrueLessThanFalseConverterObj()
        {
            long original = 1;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<long, bool>(ConvToBool.LongToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<long, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void LongToBoolGreaterThanZeroTrueLessThanFalseConverterObjSingleParam()
        {
            long original = -345;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<long, bool>(ConvToBool.LongToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        //TODO: Test Exceptions
        #endregion

        #region Short To Bool Tests
        [TestMethod]
        public void ShortToBoolOneOrZeroFalseIfOtherConverterObj()
        {
            short original = 1;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<short, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void ShortToBoolOneOrZeroFalseIfOtherConverterObjSingleParam()
        {
            short original = -23;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void ShortToBoolOneOrZeroUnconvertabeIfOtherConverterObj()
        {
            short original = 1;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<short, bool>(ConvToBool.ShortToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<short, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void ShortToBoolOneOrZeroUnconvertabeIfOtherConverterObjSingleParam()
        {
            short original = 0;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<short, bool>(ConvToBool.ShortToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void ShortToBoolGreaterThanZeroTrueLessThanFalseConverterObj()
        {
            short original = 1;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<short, bool>(ConvToBool.ShortToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<short, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void ShortToBoolGreaterThanZeroTrueLessThanFalseConverterObjSingleParam()
        {
            short original = -345;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<short, bool>(ConvToBool.ShortToBoolGreaterThanZeroTrueLessThanFalse);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        //TODO: Test Exceptions
        #endregion

        #region Uint To Bool Tests
        [TestMethod]
        public void UintToBoolOneOrZeroFalseIfOtherConverterObj()
        {
            uint original = 1U;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<uint, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void UintToBoolOneOrZeroFalseIfOtherConverterObjSingleParam()
        {
            uint original = 0;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void UintToBoolOneOrZeroUnconvertabeIfOtherConverterObj()
        {
            uint original = 1;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<uint, bool>(ConvToBool.UintToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<uint, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void UintToBoolOneOrZeroUnconvertabeIfOtherConverterObjSingleParam()
        {
            uint original = 0;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<uint, bool>(ConvToBool.UintToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        //TODO: Test Exceptions
        #endregion

        #region Ulong To Bool Tests
        [TestMethod]
        public void UlongToBoolOneOrZeroFalseIfOtherConverterObj()
        {
            ulong original = 1UL;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<ulong, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void UlongToBoolOneOrZeroFalseIfOtherConverterObjSingleParam()
        {
            ulong original = 0;
            AbstractConverter conv = new AbstractConverter();
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        [TestMethod]
        public void UlongToBoolOneOrZeroUnconvertabeIfOtherConverterObj()
        {
            ulong original = 1UL;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<ulong, bool>(ConvToBool.UlongToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<ulong, bool>(original);
            Assert.AreEqual(true, converted);
        }

        [TestMethod]
        public void UlongToBoolOneOrZeroUnconvertabeIfOtherConverterObjSingleParam()
        {
            ulong original = 0;
            AbstractConverter conv = new AbstractConverter();
            conv.Set<ulong, bool>(ConvToBool.UlongToBoolOneOrZeroUnconvertabeIfOther);
            bool converted = conv.Conv<bool>(original);
            Assert.AreEqual(false, converted);
        }

        //TODO: Test Exceptions
        #endregion
    }
}
