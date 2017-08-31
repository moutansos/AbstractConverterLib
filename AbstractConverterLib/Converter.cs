using System;
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
