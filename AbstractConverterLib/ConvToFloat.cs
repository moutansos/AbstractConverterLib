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
    }
}
