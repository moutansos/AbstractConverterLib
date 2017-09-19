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

        public static int DecimalToIntRoundDown(decimal data)
        {
            //TODO: Validate that these values can be casted without worry of exceptions or data corruption
            return (int)Math.Floor(data);
        }

        public static int DecimalToIntRoundUp(decimal data)
        {
            //TODO: Validate that these values can ve casted without worry of exceptions or data corruption
            return (int)Math.Ceiling(data);
        }

        public static int SbyteToInt(sbyte data)
        {
            return data; //No conversion necessary. Sbytes are smaller than integers.
        }

        public static int LongToInt(long data)
        {
            if (data >= int.MinValue && data <= int.MaxValue)
            {
                return Convert.ToInt32(data);
            }
            else
            {
                throw new UnconvertableDataException("The input value of " + data + " is outside the range of int");
            }
        }

        public static int ShortToInt(short data)
        {
            return data; //No conversion necessary. Value is small enough to be safely put into integer
        }

        public static int UintToInt(uint data)
        {
            if (data <= int.MaxValue)
            {
                return Convert.ToInt32(data);
            }
            else
            {
                throw new UnconvertableDataException("The input value of " + data + " is too big for a standard int");
            }
        }

        public static int UlongToInt(ulong data)
        {
            if (data <= int.MaxValue)
            {
                return Convert.ToInt32(data);
            }
            else
            {
                throw new UnconvertableDataException("The input value of " + data + " is too big for a standard int");
            }
        }

        public static int UshortToInt(ushort data)
        {
            return data;
        }

        public static int CharToIntRaw(char data)
        {
            return data;
        }
    }
}
