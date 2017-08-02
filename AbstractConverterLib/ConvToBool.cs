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

        public static bool IntToBoolOneOrZeroFalseIfOther(int data)
        {
            if(data == 1)
            {
                return true;
            }
            return false;
        }

        public static bool IntToBoolOneOrZeroUnconvertabeIfOther(int data)
        {
            if(data == 1)
            {
                return true;
            }
            else if(data == 0)
            {
                return false;
            }
            throw new UnconvertableDataException("Invalid data value of " + data + " to be converted to boolean.");
        }

        public static bool IntToBoolGreaterThanZeroTrueLessThanFalse(int data)
        {
            if(data > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ByteToBoolOneOrZeroFalseIfOther(byte data)
        {
            if (data == 1)
            {
                return true;
            }
            return false;
        }

        public static bool ByteToBoolOneOrZeroUnconvertabeIfOther(byte data)
        {
            if (data == 1)
            {
                return true;
            }
            else if (data == 0)
            {
                return false;
            }
            throw new UnconvertableDataException("Invalid data value of " + data + " to be converted to boolean.");
        }

        public static bool FloatToBoolOneOrZeroFalseIfOther(float data)
        {
            if (data == 1F)
            {
                return true;
            }
            return false;
        }

        public static bool FloatToBoolOneOrZeroUnconvertabeIfOther(float data)
        {
            if (data == 1)
            {
                return true;
            }
            else if (data == 0)
            {
                return false;
            }
            throw new UnconvertableDataException("Invalid data value of " + data + " to be converted to boolean.");
        }

        public static bool FloatToBoolGreaterThanZeroTrueLessThanFalse(float data)
        {
            if (data > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
