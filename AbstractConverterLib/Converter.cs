using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    public class Converter
    {
        #region To String Methods
        private Func<string, string> StringToString;
        private Func<bool, string> BoolToString;
        private Func<byte, string> ByteToString;
        private Func<int, string> IntToString;
        private Func<float, string> FloatToString;
        private Func<double, string> DoubleToString;
        private Func<decimal, string> DecimalToString;
        private Func<sbyte, string> SbyteToString;
        private Func<long, string> LongToString;
        private Func<short, string> ShortToString;
        private Func<uint, string> UintToString;
        private Func<ulong, string> UlongToString;
        private Func<ushort, string> UshortToString;
        private Func<char, string> CharToString;
        #endregion

        public Converter()
        {
            StringToString = ConvToString.StringToString;
            BoolToString = ConvToString.BoolToString;
            ByteToString = ConvToString.ByteToString;
            IntToString = ConvToString.IntToString;
            FloatToString = ConvToString.FloatToString;
            DoubleToString = ConvToString.DoubleToString;
            DecimalToString = ConvToString.DecimalToString;
            SbyteToString = ConvToString.SbyteToString;
            LongToString = ConvToString.LongToString;
            ShortToString = ConvToString.ShortToString;
            UintToString = ConvToString.UintToString;
            UlongToString = ConvToString.UlongToString;
            UshortToString = ConvToString.UshortToString;
            CharToString = ConvToString.CharToString;
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

        public Func<sbyte, string> SbtyeToStringMethod
        {
            set => SbyteToString = value;
        }

        public Func<long, string> LongToStringMethod
        {
            set => LongToString = value;
        }

        public Func<short, string> ShortToStringMethod
        {
            set => ShortToString = value;
        }

        public Func<uint, string> UintToStringMethod
        {
            set => UintToString = value;
        }

        public Func<ulong, string> UlongToStringMethod
        {
            set => UlongToString = value;
        }

        public Func<ushort, string> UshortToStringMethod
        {
            set => UshortToString = value;
        }

        public Func<char, string> CharToStringMethod
        {
            set => CharToString = value;
        }
        #endregion
    }
}
