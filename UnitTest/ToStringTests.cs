using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbstractConverterLib;

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

        #region Array Tests
        [TestMethod]
        public void StringArrayToString()
        {
            string[] original = { "Test1", "Test2", "Test3" };
            DataField<string[]> field = new DataField<string[]>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual("Test1, Test2, Test3", converted);
        }

        [TestMethod]
        public void IntArrayToString()
        {
            int[] original = { 4, -3, 7, 9, 56445, 435, -234 };
            DataField<int[]> field = new DataField<int[]>(original, '-');
            string converted = field.ToType<string>();
            Assert.AreEqual("4- -3- 7- 9- 56445- 435- -234", converted);
        }

        [TestMethod]
        public void ObjArrayToString()
        {
            object[] original = { 4, "Test", 543, 6.4 };
            DataField<object[]> field = new DataField<object[]>(original);
            string converted = field.ToType<string>();
            Assert.AreEqual("4, Test, 543, 6.4", converted);
        }
        #endregion
    }
}
