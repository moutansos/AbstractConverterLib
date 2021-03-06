﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    public class AbstractConverter
    {
        TypedMethodRouter router;

        public AbstractConverter()
        {
            router = new TypedMethodRouter();

            #region Default To String Methods
            router.AddMethod<string, string>(ConvToString.StringToString);
            router.AddMethod<bool, string>(ConvToString.BoolToString);
            router.AddMethod<byte, string>(ConvToString.ByteToString);
            router.AddMethod<int, string>(ConvToString.IntToString);
            router.AddMethod<float, string>(ConvToString.FloatToString);
            router.AddMethod<double, string>(ConvToString.DoubleToString);
            router.AddMethod<decimal, string>(ConvToString.DecimalToString);
            router.AddMethod<sbyte, string>(ConvToString.SbyteToString);
            router.AddMethod<long, string>(ConvToString.LongToString);
            router.AddMethod<short, string>(ConvToString.ShortToString);
            router.AddMethod<uint, string>(ConvToString.UintToString);
            router.AddMethod<ulong, string>(ConvToString.UlongToString);
            router.AddMethod<ushort, string>(ConvToString.UshortToString);
            router.AddMethod<char, string>(ConvToString.CharToString);
            #endregion

            #region Default To Int Methods
            router.AddMethod<int, int>(ConvToInt.IntToInt);
            router.AddMethod<string, int>(ConvToInt.StringToIntZeroIfEmptyOrUnconvertable);
            router.AddMethod<bool, int>(ConvToInt.BoolToInt);
            router.AddMethod<byte, int>(ConvToInt.ByteToInt);
            router.AddMethod<float, int>(ConvToInt.FloatToIntRoundDown);
            router.AddMethod<double, int>(ConvToInt.DoubleToIntRoundDown);
            router.AddMethod<decimal, int>(ConvToInt.DecimalToIntRoundDown);
            router.AddMethod<sbyte, int>(ConvToInt.SbyteToInt);
            router.AddMethod<long, int>(ConvToInt.LongToInt);
            router.AddMethod<short, int>(ConvToInt.ShortToInt);
            router.AddMethod<uint, int>(ConvToInt.UintToInt);
            router.AddMethod<ulong, int>(ConvToInt.UlongToInt);
            router.AddMethod<ushort, int>(ConvToInt.UshortToInt);
            router.AddMethod<char, int>(ConvToInt.CharToIntRaw);
            #endregion

            #region Default To Bool Methods
            router.AddMethod<bool, bool>(ConvToBool.BoolToBool);
            router.AddMethod<int, bool>(ConvToBool.IntToBoolOneOrZeroFalseIfOther);
            router.AddMethod<string, bool>(ConvToBool.StringToBoolFalseIfOther);
            router.AddMethod<byte, bool>(ConvToBool.ByteToBoolOneOrZeroFalseIfOther);
            router.AddMethod<float, bool>(ConvToBool.FloatToBoolOneOrZeroFalseIfOther);
            router.AddMethod<double, bool>(ConvToBool.DoubleToBoolOneOrZeroFalseIfOther);
            router.AddMethod<decimal, bool>(ConvToBool.DecimalToBoolOneOrZeroFalseIfOther);
            router.AddMethod<sbyte, bool>(ConvToBool.SbyteToBoolOneOrZeroFalseIfOther);
            router.AddMethod<long, bool>(ConvToBool.LongToBoolOneOrZeroFalseIfOther);
            router.AddMethod<short, bool>(ConvToBool.ShortToBoolOneOrZeroFalseIfOther);
            router.AddMethod<uint, bool>(ConvToBool.UintToBoolOneOrZeroFalseIfOther);
            router.AddMethod<ulong, bool>(ConvToBool.UlongToBoolOneOrZeroFalseIfOther);
            router.AddMethod<ushort, bool>(ConvToBool.UshortToBoolOneOrZeroFalseIfOther);
            router.AddMethod<char, bool>(ConvToBool.CharToBoolFalseIfOther);
            #endregion

            #region Default To Float Methods
            router.AddMethod<float, float>(ConvToFloat.FloatToFloat);
            router.AddMethod<string, float>(ConvToFloat.StringToFloatZeroIfEmptyOrUnconvertable);
            router.AddMethod<bool, float>(ConvToFloat.BoolToFloat);
            router.AddMethod<byte, float>(ConvToFloat.ByteToFloat);
            router.AddMethod<int, float>(ConvToFloat.IntToFloat);
            router.AddMethod<double, float>(ConvToFloat.DoubleToFloatDefaultIfUnconvertable);
            router.AddMethod<decimal, float>(ConvToFloat.DecimalToFloatDefaultIfUnconvertable);
            router.AddMethod<sbyte, float>(ConvToFloat.SbyteToFloat);
            router.AddMethod<long, float>(ConvToFloat.LongToFloat);
            router.AddMethod<short, float>(ConvToFloat.ShortToFloat);
            router.AddMethod<uint, float>(ConvToFloat.UintToFloat);
            router.AddMethod<ulong, float>(ConvToFloat.UlongToFloat);
            router.AddMethod<ushort, float>(ConvToFloat.UshortToFloat);
            router.AddMethod<char, float>(ConvToFloat.CharToFloat);
            #endregion

            #region Default To Double Methods
            router.AddMethod<double, double>(ConvToDouble.DoubleToDouble);
            router.AddMethod<string, double>(ConvToDouble.StringToDoubleZeroIfEmptyOrUnconvertable);
            router.AddMethod<bool, double>(ConvToDouble.BoolToDouble);
            router.AddMethod<byte, double>(ConvToDouble.ByteToDouble);
            router.AddMethod<int, double>(ConvToDouble.IntToDouble);
            router.AddMethod<float, double>(ConvToDouble.FloatToDouble);
            router.AddMethod<decimal, double>(ConvToDouble.DecimalToDoubleDefaultIfUnconvertable);
            router.AddMethod<sbyte, double>(ConvToDouble.SbyteToDouble);
            router.AddMethod<long, double>(ConvToDouble.LongToDouble);
            router.AddMethod<short, double>(ConvToDouble.ShortToDouble);
            router.AddMethod<uint, double>(ConvToDouble.UintToDouble);
            router.AddMethod<ulong, double>(ConvToDouble.UlongToDouble);
            router.AddMethod<ushort, double>(ConvToDouble.UshortToDouble);
            router.AddMethod<char, double>(ConvToDouble.CharToDouble);
            #endregion

            #region Default To Decimal Methods
            router.AddMethod<decimal, decimal>(ConvToDecimal.DecimalToDecimal);
            router.AddMethod<string, decimal>(ConvToDecimal.StringToDecimalZeroIfEmptyOrUnconvertable);
            router.AddMethod<bool, decimal>(ConvToDecimal.BoolToDecimal);
            router.AddMethod<byte, decimal>(ConvToDecimal.ByteToDecimal);
            router.AddMethod<int, decimal>(ConvToDecimal.IntToDecimal);
            router.AddMethod<float, decimal>(ConvToDecimal.FloatToDecimal);
            router.AddMethod<double, decimal>(ConvToDecimal.DoubleToDecimal);
            router.AddMethod<sbyte, decimal>(ConvToDecimal.SbyteToDecimal);
            router.AddMethod<long, decimal>(ConvToDecimal.LongToDecimal);
            router.AddMethod<short, decimal>(ConvToDecimal.ShortToDecimal);
            router.AddMethod<uint, decimal>(ConvToDecimal.UintToDecimal);
            router.AddMethod<ulong, decimal>(ConvToDecimal.UlongToDecimal);
            router.AddMethod<ushort, decimal>(ConvToDecimal.UshortToDecimal);
            router.AddMethod<char, decimal>(ConvToDecimal.CharToDecimal);
            #endregion

            #region Default To Long Methods
            router.AddMethod<long, long>(ConvToLong.LongToLong);
            router.AddMethod<string, long>(ConvToLong.StringToLongZeroIfEmptyOrUnconvertable);
            router.AddMethod<bool, long>(ConvToLong.BoolToLong);
            router.AddMethod<byte, long>(ConvToLong.ByteToLong);
            router.AddMethod<float, long>(ConvToLong.FloatToLongRoundDown);
            router.AddMethod<double, long>(ConvToLong.DoubleToLongRoundDown);
            router.AddMethod<decimal, long>(ConvToLong.DecimalToLongRoundDown);
            router.AddMethod<sbyte, long>(ConvToLong.SbyteToLong);
            router.AddMethod<int, long>(ConvToLong.IntToLong);
            router.AddMethod<short, long>(ConvToLong.ShortToLong);
            router.AddMethod<uint, long>(ConvToLong.UintToLong);
            router.AddMethod<ulong, long>(ConvToLong.UlongToLongDefaultIfUnconvertable);
            router.AddMethod<ushort, long>(ConvToLong.UshortToLong);
            router.AddMethod<char, long>(ConvToLong.CharToLongRaw);
            #endregion
        }

        public OUT Conv<IN, OUT>(IN dataIn)
        {
            if(router.ContainsRoute(typeof(IN), typeof(OUT)))
            {
                return (OUT)Convert.ChangeType(router.Call(dataIn, typeof(IN), typeof(OUT)), typeof(OUT));
            }
            else
            {
                throw new UnableToConvertTypeException("Unable to convert " + typeof(IN) + " to " + typeof(OUT));
            }
        }

        public OUT Conv<OUT>(object dataIn)
        {
            if (router.ContainsRoute(dataIn.GetType(), typeof(OUT)))
            {
                return (OUT)Convert.ChangeType(router.Call(dataIn, dataIn.GetType(), typeof(OUT)), typeof(OUT));
            }
            else
            {
                throw new UnableToConvertTypeException("Unable to convert " + dataIn.GetType() + " to " + typeof(OUT));
            }
        }

        public void Set<IN, OUT>(Func<IN, OUT> method)
        {
            router.AddMethod(method);
        }
    }

    public class TypedMethodRouter
    {
        private Dictionary<Tuple<Type, Type>, dynamic> dict;

        public TypedMethodRouter()
        {
            dict = new Dictionary<Tuple<Type, Type>, dynamic>();
        }

        public void AddMethod<IN, OUT>(Func<IN, OUT> method)
        {
            Tuple<Type, Type> key = new Tuple<Type, Type>(typeof(IN), typeof(OUT));
            dict[key] = method;
        }

        public Func<IN, OUT> GetMethod<IN, OUT>()
        {
            Tuple<Type, Type> key = new Tuple<Type, Type>(typeof(IN), typeof(OUT));
            Func<IN, OUT> converted = dict[key];
            return converted;
        }

        public object Call(dynamic inVal, Type inType, Type outType)
        {
            Tuple<Type, Type> key = new Tuple<Type, Type>(inType, outType);
            return dict[key](inVal);
        }

        public bool ContainsRoute(Type inType, Type outType)
        {
            Tuple<Type, Type> key = new Tuple<Type, Type>(inType, outType);
            if(dict.ContainsKey(key))
            {
                return true;
            }
            return false;
        }

        public bool ContainsRoute<IN, OUT>()
        {
            return ContainsRoute(typeof(IN), typeof(OUT));
        }
    }
}
