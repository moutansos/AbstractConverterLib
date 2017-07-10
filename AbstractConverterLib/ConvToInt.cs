using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    static class ConvToInt
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
    }
}
