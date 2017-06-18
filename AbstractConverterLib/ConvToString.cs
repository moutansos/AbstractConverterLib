using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractConverterLib
{
    class ConvToString
    {
        private const string EVALTYPEERROR = "AbstractConverterLib Internal Error: Invalid EvalType";

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
            else
            {
                throw new InvalidCastException("The cast of type " + typeof(T) + " to the type of " + typeof(string) + " is not supported.");
            }
        }

        private static K StringToString<K>(object data)
        {
            return (K)Convert.ChangeType(data, typeof(string));
        }

        private static K IntToString<K>(object data)
        {
            //Convert
            string newStr = (int)Convert.ChangeType(data, typeof(int)) + "";

            return (K)Convert.ChangeType(data, typeof(K));
        }
    }
}
