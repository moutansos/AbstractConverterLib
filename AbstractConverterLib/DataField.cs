using System;

namespace AbstractConverterLib
{
    public class DataField<T>
    {
        private T data;
        private EvalType type;

        #region Constructors
        public DataField(T data) : this(data, EvalType.DefaultIfUnconvertable) { }

        public DataField(T data, EvalType evaluationType)
        {
            this.data = data;
            type = evaluationType;
        }
        #endregion

        public K ToType<K>()
        {
            if(typeof(K) == typeof(string))
            {
                return ConvToString.Conv<T, K>(data, type);
            }
            else
            {
                throw new InvalidCastException("The cast of type " + typeof(T) + " to the type of " + typeof(K) + " is not supported.");
            }
        }
    }

    public enum EvalType
    {
        DefaultIfUnconvertable,
        ExceptionOnUnconvertable
    }
}
