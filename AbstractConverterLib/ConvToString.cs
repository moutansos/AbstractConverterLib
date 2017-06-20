using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    class ConvToString
    {
        public static OUT Conv<OUT>(object dataIn, Type dataInType, EvalType type, char collectionDelimiter)
        {
            if (dataInType == typeof(string))
            {
                return StringToString<OUT>(dataIn);
            }
            else if(dataInType == typeof(bool))
            {
                return BoolToString<OUT>(dataIn);
            }
            else if (dataInType == typeof(int))
            {
                return IntToString<OUT>(dataIn);
            }
            else if (dataInType == typeof(float))
            {
                return FloatToString<OUT>(dataIn);
            }
            else if (dataInType == typeof(double))
            {
                return DoubleToString<OUT>(dataIn);
            }
            else if (dataInType.ToString().EndsWith("[]")) //This is a hack. Find a better method of doing this
            {
                return ArrayToString<OUT>(dataIn, type, collectionDelimiter);
            }
            else if(dataInType.ToString().StartsWith("System.Collections.Generic.List"))// This is a hack. Find a better method of doing this
            {
                return ListToString<OUT>(dataIn, type, collectionDelimiter); 
            }
            else
            {
                throw new InvalidCastException("The cast of type " + dataInType + " to the type of " + typeof(string) + " is not supported.");
            }
        }

        public static OUT Conv<IN, OUT>(IN dataIn, EvalType type, char collectionDelimiter)
        {
            return Conv<OUT>(dataIn, typeof(IN), type, collectionDelimiter);
        }

        private static K changeType<K>(object data)
        {
            return (K)Convert.ChangeType(data, typeof(K));
        }

        private static K StringToString<K>(object data)
        {
            return changeType<K>(data);
        }

        private static K BoolToString<K>(object data)
        {
            //Convert
            string newStr = (bool)Convert.ChangeType(data, typeof(bool)) + "";

            return changeType<K>(newStr);
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

        private static K ArrayToString<K>(object data, EvalType eval, char collectionDelimiter)
        {
            dynamic ara = data;

            string outStr = "";
            for (int i = 0; i < ara.Length; i++)
            {
                Type originalType = ara[i].GetType();
                string elStr = Conv<string>(ara[i], originalType, eval, collectionDelimiter);
                if (i == 0)
                {
                    outStr = outStr + elStr;
                }
                else
                {
                    outStr = outStr + collectionDelimiter + " " + elStr;
                }
            }
            return changeType<K>(outStr);
        }

        private static K ListToString<K>(object data, EvalType eval, char collectionDelimiter)
        {
            dynamic list = data;

            string outStr = "";
            for(int i = 0; i < list.Count; i++)
            {
                Type originalType = list[i].GetType();
                string elStr = Conv<string>(list[i], originalType, eval, collectionDelimiter);
                if (i == 0)
                {
                    outStr = outStr + elStr;
                }
                else
                {
                    outStr = outStr + collectionDelimiter + " " + elStr;
                }
            }
            return changeType<K>(outStr);
        }
    }
}
