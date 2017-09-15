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
            throw new UnconvertableDataException("Unable to convert \"" + data + "\" to a double.");
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

        public static double IntToDouble(int data)
        {
            return data;
        }

        public static double FloatToDouble(float data)
        {
            return data;
        }

        public static double DecimalToDoubleDefaultIfUnconvertable(decimal data)
        {
            try
            {
                return decimal.ToDouble(data);
            }
            catch (OverflowException)
            {
                return 0D;
            }
        }

        public static double DecimalToDoubleExceptionIfUnconvertable(decimal data)
        {
            try
            {
                return decimal.ToDouble(data);
            }
            catch (OverflowException)
            {
                throw new UnconvertableDataException("Unable to convert " + data + " to a double. The value doesn't fit in the data type.");
            }
        }

        public static double SbyteToDouble(sbyte data)
        {
            return data;
        }

        public static double LongToDouble(long data)
        {
            return data;
        }

        public static double ShortToDouble(short data)
        {
            return data;
        }

        public static double UintToDouble(uint data)
        {
            return data;
        }

        public static double UlongToDouble(ulong data)
        {
            return data;
        }

        public static double UshortToDouble(ushort data)
        {
            return data;
        }

        public static double CharToDouble(char data)
        {
            return data;
        }
    }
}
