using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractConverterLib
{
    public class UnableToConvertException : InvalidCastException
    {
        public UnableToConvertException() : base () { }
        public UnableToConvertException(string msg) : base(msg) { }
    }
}
