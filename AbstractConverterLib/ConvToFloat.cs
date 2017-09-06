using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    public static class ConvToFloat
    {
        public static float FloatToFloat(float data)
        {
            return data;
        }

        public static float StringToFloatZeroIfEmptyOrUnconvertable(string data)
        {
            data = data.Trim().TrimEnd(new char[] { 'F', 'f' });
            if (float.TryParse(data, out float retData))
            {
                return retData;
            }
            return 0;
        }

        public static float StringToFloatExceptionIfUnconvertable(string data)
        {
            data = data.Trim().TrimEnd(new char[] { 'F', 'f' });
            if (float.TryParse(data, out float retData))
            {
                return retData;
            }
            throw new UnconvertableDataException("Unable to convert \"" + data + "\" to a float.");
        }

        public static float BoolToFloat(bool data)
        {
            if(data)
            {
                return 1F;
            }
            return 0F;
        }

        public static float ByteToFloat(byte data)
        {
            return data;
        }

        public static float IntToFloat(int data)
        {
            return data;
        }

        public static float DoubleToFloatDefaultIfUnconvertable(double data)
        {
            if(data <= float.MaxValue && data >= float.MinValue)
            {
                return (float)data;
            }
            return 0F;
        }

        public static float DoubleToFloatExceptionIfUnconvertable(double data)
        {
            if (data <= float.MaxValue && data >= float.MinValue)
            {
                return (float)data;
            }
            throw new UnconvertableDataException("Unable to convert " + data + " to a float. The value doesn't fit in this data type.");
        }

        public static float DecimalToFloatDefaultIfUnconvertable(decimal data)
        {
            try
            {
                return decimal.ToSingle(data);
            }
            catch(OverflowException ex)
            {
                return 0F;
            }
        }

        public static float DecimalToFloatExceptionIfUnconvertable(decimal data)
        {
            try
            {
                return decimal.ToSingle(data);
            }
            catch (OverflowException)
            {
                throw new UnconvertableDataException("Unable to convert " + data + " to a float. The value doesn't fit in the data type.");
            }
        }

        public static float SbyteToFloat(sbyte data)
        {
            return data;
        }

        public static float LongToFloat(long data)
        {
            return data;
        }

        public static float ShortToFloat(short data)
        {
            return data;
        }

        public static float UintToFloat(uint data)
        {
            return data;
        }

        public static float UlongToFloat(ulong data)
        {
            return data;
        }
    }
}
