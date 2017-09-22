using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    public static class ConvToLong
    {
        public static long LongToLong(long data)
        {
            return data;
        }

        public static long StringToLongZeroIfEmptyOrUnconvertable(string data)
        {
            data = data.Trim();
            if (long.TryParse(data, out long retData))
            {
                return retData;
            }
            return 0;
        }

        public static long StringToLongExceptionIfUnconvertable(string data)
        {
            if (long.TryParse(data, out long retData))
            {
                return retData;
            }
            throw new UnconvertableDataException("Unable to convert \"" + data + "\" to a long.");
        }

        public static long BoolToLong(bool data)
        {
            if (data)
            {
                return 1;
            }
            return 0;
        }

        public static long ByteToLong(byte data)
        {
            return data;
        }

        public static long FloatToLongRoundDown(float data)
        {
            //TODO: Validate that these values can be casted without worry of exceptions or data corruption
            return (long)Math.Floor(data);
        }

        public static long FloatToLongRoundUp(float data)
        {
            //TODO: Validate that these values can ve casted without worry of exceptions or data corruption
            return (long)Math.Ceiling(data);
        }

        public static long DoubleToLongRoundDown(double data)
        {
            //TODO: Validate that these values can be casted without worry of exceptions or data corruption
            return (long)Math.Floor(data);
        }

        public static long DoubleToLongRoundUp(double data)
        {
            //TODO: Validate that these values can ve casted without worry of exceptions or data corruption
            return (long)Math.Ceiling(data);
        }

        public static long DecimalToLongRoundDown(decimal data)
        {
            //TODO: Validate that these values can be casted without worry of exceptions or data corruption
            return (long)Math.Floor(data);
        }

        public static long DecimalToLongRoundUp(decimal data)
        {
            //TODO: Validate that these values can ve casted without worry of exceptions or data corruption
            return (long)Math.Ceiling(data);
        }

        public static long SbyteToLong(sbyte data)
        {
            return data;
        }

        public static long IntToLong(int data)
        {
            return data;
        }

        public static long ShortToLong(short data)
        {
            return data;
        }

        public static long UintToLong(uint data)
        {
            return data;
        }

        public static long UlongToLongExceptionIfUnconvertable(ulong data)
        {
            if (data <= long.MaxValue)
            {
                return Convert.ToInt64(data);
            }
            else
            {
                throw new UnconvertableDataException("The input value of " + data + " is too big for a long integer");
            }
        }

        public static long UlongToLongDefaultIfUnconvertable(ulong data)
        {
            if (data <= long.MaxValue)
            {
                return Convert.ToInt64(data);
            }
            return 0;
        }

        public static long UshortToLong(ushort data)
        {
            return data;
        }

        public static long CharToLongRaw(char data)
        {
            return data;
        }
    }
}
