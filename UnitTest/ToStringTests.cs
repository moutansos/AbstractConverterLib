using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractConverterLib;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class ToStringTests
    {
        [TestMethod]
        public void StringToStringDataField()
        {
            string original = "This is a test string!";
            DataField<string> field = new DataField<string>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original, converted);
        }

        [TestMethod]
        public void BoolToStringDataField()
        {
            bool original = true;
            DataField<bool> field = new DataField<bool>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original.ToString(), converted);
        }

        [TestMethod]
        public void ByteToStringDataField()
        {
            byte original = 123;
            DataField<byte> field = new DataField<byte>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void IntToStringDataField()
        {
            int original = -123124891;
            DataField<int> field = new DataField<int>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void FloatToStringDataField()
        {
            float original = -1249999999999999999;
            DataField<float> field = new DataField<float>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void DoubleToStringDataField()
        {
            double original = -2901391283904032333;
            DataField<double> field = new DataField<double>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void DecimalToStringDataField()
        {
            decimal original = -2923338989098908989;
            DataField<decimal> field = new DataField<decimal>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void SbyteToStringDataField()
        {
            sbyte original = -25;
            DataField<sbyte> field = new DataField<sbyte>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void LongToStringDataField()
        {
            long original = -2923338989098908989;
            DataField<long> field = new DataField<long>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void ShortToStringDataField()
        {
            short original = -28989;
            DataField<short> field = new DataField<short>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void UintToStringDataField()
        {
            uint original = 2923338989;
            DataField<uint> field = new DataField<uint>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void UlongToStringDataField()
        {
            ulong original = 2923338989098908989;
            DataField<ulong> field = new DataField<ulong>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void UshortToStringDataField()
        {
            ushort original = 223;
            DataField<ushort> field = new DataField<ushort>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original + "", converted);
        }

        [TestMethod]
        public void CharToStringDataField()
        {
            char original = 'd';
            DataField<char> field = new DataField<char>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual(original + "", converted);
        }

        #region Array Tests
        [TestMethod]
        public void StringArrayToStringDataField()
        {
            string[] original = { "Test1", "Test2", "Test3" };
            DataField<string[]> field = new DataField<string[]>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual("Test1, Test2, Test3", converted);
        }

        [TestMethod]
        public void IntArrayToStringDataField()
        {
            int[] original = { 4, -3, 7, 9, 56445, 435, -234 };
            DataField<int[]> field = new DataField<int[]>(original, '-');
            string converted = field.ToType<string>();
            Assert.AreEqual("4- -3- 7- 9- 56445- 435- -234", converted);
        }

        [TestMethod]
        public void ObjArrayToStringDataField()
        {
            object[] original = { 4, "Test", 543, 6.4 };
            DataField<object[]> field = new DataField<object[]>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual("4, Test, 543, 6.4", converted);
        }
        #endregion

        #region List Tests
        public void StringListToStringDataField()
        {
            List<string> original = new List<string>(new string[]{ "Test1", "Test2", "Test3" });
            DataField<List<string>> field = new DataField<List<string>>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual("Test1, Test2, Test3", converted);
        }

        [TestMethod]
        public void IntListToStringDataField()
        {
            int[] original = { 4, -3, 7, 9, 56445, 435, -234 };
            DataField<int[]> field = new DataField<int[]>(original, '-');
            string converted = field.ToType<string>();
            Assert.AreEqual("4- -3- 7- 9- 56445- 435- -234", converted);
        }

        [TestMethod]
        public void ObjListToStringDataField()
        {
            List<object> original = new List<object>(new object[]{ 4, "Test", 543, 6.4 });
            DataField<List<object>> field = new DataField<List<object>>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual("4, Test, 543, 6.4", converted);
        }
        #endregion
    }
}
