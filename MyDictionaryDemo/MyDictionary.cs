using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryDemo
{
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] _key;
        Tvalue[] _value;
        Tkey[] tempKey;
        Tvalue[] tempValue;


        public MyDictionary()
        {
            _key = new Tkey[0];
            _value = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            tempKey = _key;
            tempValue = _value;

            _key = new Tkey[_key.Length + 1];
            _value = new Tvalue[_value.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                _key[i] = tempKey[i];
                _value[i] = tempValue[i];
            }
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }



        public int lenght
        {
            get { return _key.Length; }

        }

        public Tkey[] Keys
        {
            get { return _key; }

        }

        public Tvalue[] Values
        {
            get { return _value; }

        }
    }
}
