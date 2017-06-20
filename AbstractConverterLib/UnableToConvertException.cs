using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    public class UnableToConvertException : InvalidCastException
    {
        public UnableToConvertException() : base() { }
        public UnableToConvertException(string msg) : base(msg) { }
    }
}
