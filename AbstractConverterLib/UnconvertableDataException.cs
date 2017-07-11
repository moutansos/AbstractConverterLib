using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    public class UnconvertableDataException : InvalidCastException
    {
        public UnconvertableDataException() : base() { }
        public UnconvertableDataException(string msg) : base(msg) { }
    }
}
