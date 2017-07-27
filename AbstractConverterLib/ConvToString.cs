using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    public static class ConvToString
    {
        public static OUT Conv<OUT>(object dataIn, Type dataInType, EvalType type, char collectionDelimiter)
        {
            if (dataInType == typeof(string))
            {
                string converted = ChangeTypeAndConvert<string, string>(dataIn, StringToString);
                return ChangeType<OUT>(converted);
            }
            else if (dataInType == typeof(bool))
            {
                string converted = ChangeTypeAndConvert<string, bool>(dataIn, BoolToString);
                return ChangeType<OUT>(converted);
            }
            else if (dataInType == typeof(byte))
            {
                string converted = ChangeTypeAndConvert<string, byte>(dataIn, ByteToString);
                return ChangeType<OUT>(converted);
            }
            else if (dataInType == typeof(int))
            {
                string converted = ChangeTypeAndConvert<string, int>(dataIn, IntToString);
                return ChangeType<OUT>(converted);
            }
            else if (dataInType == typeof(float))
            {
                string converted = ChangeTypeAndConvert<string, float>(dataIn, FloatToString);
                return ChangeType<OUT>(converted);
            }
            else if (dataInType == typeof(double))
            {
                string converted = ChangeTypeAndConvert<string, double>(dataIn, DoubleToString);
                return ChangeType<OUT>(converted);
            }
            else if (dataInType == typeof(decimal))
            {
                string converted = ChangeTypeAndConvert<string, decimal>(dataIn, DecimalToString);
                return ChangeType<OUT>(converted);
            }
            else if (dataInType == typeof(sbyte))
            {
                string converted = ChangeTypeAndConvert<string, sbyte>(dataIn, SbyteToString);
                return ChangeType<OUT>(converted);
            }
            else if (dataInType == typeof(long))
            {
                string converted = ChangeTypeAndConvert<string, long>(dataIn, LongToString);
                return ChangeType<OUT>(converted);
            }
            else if (dataInType == typeof(short))
            {
                string converted = ChangeTypeAndConvert<string, short>(dataIn, ShortToString);
                return ChangeType<OUT>(converted);
            }
            else if (dataInType == typeof(uint))
            {
                string converted = ChangeTypeAndConvert<string, uint>(dataIn, UintToString);
                return ChangeType<OUT>(converted);
            }
            else if (dataInType == typeof(ulong))
            {
                string converted = ChangeTypeAndConvert<string, ulong>(dataIn, UlongToString);
                return ChangeType<OUT>(converted);
            }
            else if (dataInType == typeof(ushort))
            {
                string converted = ChangeTypeAndConvert<string, ushort>(dataIn, UshortToString);
                return ChangeType<OUT>(converted);
            }
            else if (dataInType == typeof(char))
            {
                string converted = ChangeTypeAndConvert<string, char>(dataIn, CharToString);
                return ChangeType<OUT>(converted);
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

        private static K ChangeType<K>(object data)
        {
            return (K)Convert.ChangeType(data, typeof(K));
        }

        private static OUT ChangeTypeAndConvert<OUT, ORIGIN>(object dataIn, Func<ORIGIN, OUT> conversionMethod)
        {
            ORIGIN originalData = ChangeType<ORIGIN>(dataIn);
            OUT outData = conversionMethod(originalData);
            return outData;
        }

        public static string StringToString(string data)
        {
            return data;
        }

        public static string BoolToString(bool data)
        {
            return data + "";
        }

        public static string ByteToString(byte data)
        {
            return data + "";
        }

        public static string IntToString(int data)
        {
            return data + "";
        }

        public static string FloatToString(float data)
        {
            return data + "";
        }

        public static string DoubleToString(double data)
        {
            return data + "";
        }

        public static string DecimalToString(decimal data)
        {
            return data + "";
        }

        public static string SbyteToString(sbyte data)
        {
            return data + "";
        }

        public static string LongToString(long data)
        {
            return data + "";
        }

        public static string ShortToString(short data)
        {
            return data + "";
        }

        public static string UintToString(uint data)
        {
            return data + "";
        }

        public static string UlongToString(ulong data)
        {
            return data + "";
        }

        public static string UshortToString(ushort data)
        {
            return data + "";
        }

        public static string CharToString(char data)
        {
            return data + "";
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
            return ChangeType<K>(outStr);
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
            return ChangeType<K>(outStr);
        }
    }
}
