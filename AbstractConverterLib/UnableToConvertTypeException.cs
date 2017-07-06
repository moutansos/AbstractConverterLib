using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    public class UnableToConvertTypeException : InvalidCastException
    {
        public UnableToConvertTypeException() : base() { }
        public UnableToConvertTypeException(string msg) : base(msg) { }
    }
}
