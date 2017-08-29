using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    public static class ConvToInt
    {
        public static int IntToInt(int data)
        {
            return data;
        }

        public static int StringToIntZeroIfEmptyOrUnconvertable(string data)
        {
            data = data.Trim();
            if(int.TryParse(data, out int retData))
            {
                return retData;
            }
            return 0;
        }

        //TODO: Add unconvertable data exception on unable to parse (see float)

        public static int BoolToInt(bool data)
        {
            if(data)
            {
                return 1;
            }
            return 0;
        }

        public static int ByteToInt(byte data)
        {
            return data;
        }

        public static int FloatToIntRoundDown(float data)
        {
            //TODO: Validate that these values can be casted without worry of exceptions or data corruption
            return (int)Math.Floor(data);
        }

        public static int FloatToIntRoundUp(float data)
        {
            //TODO: Validate that these values can ve casted without worry of exceptions or data corruption
            return (int)Math.Ceiling((double)data);
        }

        public static int DoubleToIntRoundDown(double data)
        {
            //TODO: Validate that these values can be casted without worry of exceptions or data corruption
            return (int)Math.Floor(data);
        }

        public static int DoubleToIntRoundUp(double data)
        {
            //TODO: Validate that these values can ve casted without worry of exceptions or data corruption
            return (int)Math.Ceiling(data);
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
            if(data >= int.MinValue && data <= int.MaxValue)
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
            if(data <= int.MaxValue)
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
            if(data <= int.MaxValue)
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
