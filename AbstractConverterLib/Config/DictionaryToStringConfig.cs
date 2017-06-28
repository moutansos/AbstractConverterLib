using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractConverterLib.Config
{
    abstract class DictronaryToStringConverter
    {
        protected object dict;
        protected Type keyType;
        protected Type valType;

        public DictronaryToStringConverter()
        {
            
        }

        public Type key
        {
            get => keyType;
        }

        public Type value
        {
            get => valType;
        }

        public object dictionary
        {
            set => dict = value;
        }

        protected bool isDictionary()
        {
            if(dict != null)
            {
                Type dictType = dict.GetType();
                string typeStr = dictType.ToString();

                if (typeStr.StartsWith("[System.Collections.Generic.Dictionary"))
                {
                    return true;
                }
            }
            return false;
        }

        protected void evalKeyType(object dictionary)
        {
            throw new NotImplementedException();
        }

        public abstract string convertToString(bool useWhitespace);
    }

    class DictionaryToJsonStringConverter : DictronaryToStringConverter
    {   
        public DictionaryToJsonStringConverter()
        {
        }

        public override string convertToString(bool useWhitespace)
        {
            //TODO: Implement using Newtonsoft.JSON
            throw new NotImplementedException();
        }
    }

    class DictionaryToDefaultStringConverter : DictronaryToStringConverter
    {
        public DictionaryToDefaultStringConverter()
        {

        }

        public override string convertToString(bool useWhitespace)
        {
            throw new NotImplementedException();
        }
    }
}
