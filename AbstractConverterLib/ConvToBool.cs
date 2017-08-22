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

        //TODO: String to bool

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
            if (data == 1F)
            {
                return true;
            }
            else if (data == 0F)
            {
                return false;
            }
            throw new UnconvertableDataException("Invalid data value of " + data + " to be converted to boolean.");
        }

        public static bool FloatToBoolGreaterThanZeroTrueLessThanFalse(float data)
        {
            if (data > 0F)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DoubleToBoolOneOrZeroFalseIfOther(double data)
        {
            if (data == 1D)
            {
                return true;
            }
            return false;
        }

        public static bool DoubleToBoolOneOrZeroUnconvertabeIfOther(double data)
        {
            if (data == 1D)
            {
                return true;
            }
            else if (data == 0D)
            {
                return false;
            }
            throw new UnconvertableDataException("Invalid data value of " + data + " to be converted to boolean.");
        }

        public static bool DoubleToBoolGreaterThanZeroTrueLessThanFalse(double data)
        {
            if (data > 0D)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DecimalToBoolOneOrZeroFalseIfOther(decimal data)
        {
            if (data == 1m)
            {
                return true;
            }
            return false;
        }

        public static bool DecimalToBoolOneOrZeroUnconvertabeIfOther(decimal data)
        {
            if (data == 1m)
            {
                return true;
            }
            else if (data == 0m)
            {
                return false;
            }
            throw new UnconvertableDataException("Invalid data value of " + data + " to be converted to boolean.");
        }

        public static bool DecimalToBoolGreaterThanZeroTrueLessThanFalse(decimal data)
        {
            if (data > 0m)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SbyteToBoolOneOrZeroFalseIfOther(sbyte data)
        {
            if (data == 1)
            {
                return true;
            }
            return false;
        }

        public static bool SbyteToBoolOneOrZeroUnconvertabeIfOther(sbyte data)
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

        public static bool SbyteToBoolGreaterThanZeroTrueLessThanFalse(sbyte data)
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

        public static bool LongToBoolOneOrZeroFalseIfOther(long data)
        {
            if (data == 1L)
            {
                return true;
            }
            return false;
        }

        public static bool LongToBoolOneOrZeroUnconvertabeIfOther(long data)
        {
            if (data == 1L)
            {
                return true;
            }
            else if (data == 0L)
            {
                return false;
            }
            throw new UnconvertableDataException("Invalid data value of " + data + " to be converted to boolean.");
        }

        public static bool LongToBoolGreaterThanZeroTrueLessThanFalse(long data)
        {
            if (data > 0L)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ShortToBoolOneOrZeroFalseIfOther(short data)
        {
            if (data == 1)
            {
                return true;
            }
            return false;
        }

        public static bool ShortToBoolOneOrZeroUnconvertabeIfOther(short data)
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

        public static bool ShortToBoolGreaterThanZeroTrueLessThanFalse(short data)
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

        public static bool UintToBoolOneOrZeroFalseIfOther(uint data)
        {
            if (data == 1U)
            {
                return true;
            }
            return false;
        }

        public static bool UintToBoolOneOrZeroUnconvertabeIfOther(uint data)
        {
            if (data == 1U)
            {
                return true;
            }
            else if (data == 0U)
            {
                return false;
            }
            throw new UnconvertableDataException("Invalid data value of " + data + " to be converted to boolean.");
        }

        public static bool UlongToBoolOneOrZeroFalseIfOther(ulong data)
        {
            if (data == 1UL)
            {
                return true;
            }
            return false;
        }

        public static bool UlongToBoolOneOrZeroUnconvertabeIfOther(ulong data)
        {
            if (data == 1UL)
            {
                return true;
            }
            else if (data == 0UL)
            {
                return false;
            }
            throw new UnconvertableDataException("Invalid data value of " + data + " to be converted to boolean.");
        }

        public static bool UshortToBoolOneOrZeroFalseIfOther(ushort data)
        {
            if (data == 1)
            {
                return true;
            }
            return false;
        }

        public static bool UshortToBoolOneOrZeroUnconvertabeIfOther(ushort data)
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

        public static bool CharToBoolWithUnconvertable(char data)
        {
            if (data == 'T' || data == '1' || data == 'Y')
            {
                return true;
            }
            else if (data == 'F' || data == '0' || data == 'N')
            {
                return false;
            }
            throw new UnconvertableDataException("The data value of \'" + data + "\' is unknown.");
        }

        public static bool CharToBoolFalseIfOther(char data)
        {
            if (data == 'T' || data == '1' || data == 'Y')
            {
                return true;
            }
            return false;
        }
    }
}
