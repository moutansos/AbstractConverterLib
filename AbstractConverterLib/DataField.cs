using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    public class DataField<T>
    {
        private T data;
        private EvalType type;
        private char collectionDelimiter;

        #region Constructors
        public DataField(T data, char collectionDelimiter) : this(data, EvalType.DefaultIfUnconvertable, collectionDelimiter) { }

        public DataField(T data) : this(data, EvalType.DefaultIfUnconvertable, ',') { }

        public DataField(T data, EvalType evaluationType, char collectionDelimiter)
        {
            this.data = data;
            type = evaluationType;
            this.collectionDelimiter = collectionDelimiter;
        }
        #endregion

        public K ToType<K>()
        {
            if (typeof(K) == typeof(string))
            {
                return ConvToString.Conv<T, K>(data, type, collectionDelimiter);
            }
            else
            {
                throw new InvalidCastException("The cast of type " + typeof(T) + " to the type of " + typeof(K) + " is not supported.");
            }
        }
    }
}
