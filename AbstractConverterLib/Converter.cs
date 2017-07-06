using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    public class Converter
    {
        private Func<string, string> StringToString;
        private Func<bool, string> BoolToString;
        private Func<byte, string> ByteToString;
        private Func<int, string> IntToString;
        private Func<float, string> FloatToString;
        private Func<double, string> DoubleToString;
        private Func<decimal, string> DecimalToString;

        public Converter()
        {

        }

        #region To String Properties
        public Func<string, string> StringToStringMethod
        {
            set => StringToString = value;
        }

        public Func<bool, string> BoolToStringMethod
        {
            set => BoolToString = value;
        }

        public Func<byte, string> ByteToStringMethod
        {
            set => ByteToString = value;
        }

        public Func<int, string> IntToStringMethod
        {
            set => IntToString = value;
        }

        public Func<float, string> FloatToStringMethod
        {
            set => FloatToString = value;
        }

        public Func<double, string> DoubleToStringMethod
        {
            set => DoubleToString = value;
        }

        public Func<decimal, string> DecimalToStringMethod
        {
            set => DecimalToString = value;
        }
        #endregion
    }
}
