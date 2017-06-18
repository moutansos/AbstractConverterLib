using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractConverterLib
{
    class ConvToString
    {
        public static K Conv<T, K>(T dataIn, EvalType type)
        {
            if(typeof(T) == typeof(string))
            {
                return StringToString<K>(dataIn);
            }
            else if(typeof(T) == typeof(int))
            {
                return IntToString<K>(dataIn);
            }
            else if(typeof(T) == typeof(float))
            {
                return FloatToString<K>(dataIn);
            }
            else if(typeof(T) == typeof(double))
            {
                return DoubleToString<K>(dataIn);
            }
            else
            {
                throw new InvalidCastException("The cast of type " + typeof(T) + " to the type of " + typeof(string) + " is not supported.");
            }
        }

        private static K changeType<K>(object data)
        {
            return (K)Convert.ChangeType(data, typeof(K));
        }

        private static K StringToString<K>(object data)
        {
            return changeType<K>(data);
        }

        private static K IntToString<K>(object data)
        {
            //Convert
            string newStr = (int)Convert.ChangeType(data, typeof(int)) + "";

            return changeType<K>(newStr);
        }

        private static K FloatToString<K>(object data)
        {
            //Convert
            string newStr = (float)Convert.ChangeType(data, typeof(float)) + "";

            return changeType<K>(newStr);
        }

        private static K DoubleToString<K>(object data)
        {
            //Convert
            string newStr = (double)Convert.ChangeType(data, typeof(double)) + "";

            return changeType<K>(newStr);
        }
    }
}
