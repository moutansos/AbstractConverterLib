using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    public static class ConvToBool
    {
        public static bool BoolToBool(bool data)
        {
            return data;
        }

        public static bool BoolToBoolToggle(bool data)
        {
            return !data;
        }
    }
}
