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
            int retData = 0;
            if(int.TryParse(data, out retData))
            {
                return retData;
            }
            return 0;
        }

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


    }
}
