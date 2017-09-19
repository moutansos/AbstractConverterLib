using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    public class ConvToDecimal
    {
        public static decimal DecimalToDecimal(decimal data)
        {
            return data;
        }

        public static decimal StringToDecimalZeroIfEmptyOrUnconvertable(string data) //TODO: Add float/double? parsing
        {
            data = data.Trim().TrimEnd(new char[] { 'M', 'm' }); //TODO: Change to constants
            if (decimal.TryParse(data, out decimal retData))
            {
                return retData;
            }
            return 0m;
        }

        public static decimal StringToDecimalExceptionIfUnconvertable(string data) //TODO: Add float/double? parsing
        {
            data = data.Trim().TrimEnd(new char[] { 'M', 'm' }); //TODO: Change to constants
            if (decimal.TryParse(data, out decimal retData))
            {
                return retData;
            }
            throw new UnconvertableDataException("Unable to convert \"" + data + "\" to a decimal.");
        }

        public static decimal BoolToDecimal(bool data)
        {
            if (data)
            {
                return 1m;
            }
            return 0m;
        }

        public static decimal ByteToDecimal(byte data)
        {
            return data;
        }

        public static decimal IntToDecimal(int data)
        {
            return data;
        }

        public static decimal FloatToDecimal(float data)
        {
            return Convert.ToDecimal(data);
        }

        public static decimal DoubleToDecimal(double data)
        {
            return Convert.ToDecimal(data);
        }

        public static decimal SbyteToDecimal(sbyte data)
        {
            return data;
        }

        public static decimal LongToDecimal(long data)
        {
            return data;
        }

        public static decimal ShortToDecimal(short data)
        {
            return data;
        }

        public static decimal UintToDecimal(uint data)
        {
            return data;
        }

        public static decimal UlongToDecimal(ulong data)
        {
            return data;
        }

        public static decimal UshortToDecimal(ushort data)
        {
            return data;
        }

        public static decimal CharToDecimal(char data)
        {
            return data;
        }
    }
}
