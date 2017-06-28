using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib
{
    class ConverterConfig
    {
        public ConverterConfig()
        {

        }

        public enum DefaultConversionType
        {
            DefaultIfUnconvertable, //Return the default value of the destination type
            ExceptionOnUnconvertable, //Throw an unconvertable exception on unconvertable but still cast single items into single element arrays or lists
            StrictExceptionOnUnconvertable //Even conversion to an array or list of the same type will throw an exception
        }
    }
}
