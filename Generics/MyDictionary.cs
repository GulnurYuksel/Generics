using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] keyArray = keys;
            keys = new K[keys.Length + 1];
            V[] valueArray = values;
            values = new V[values.Length + 1];

            for (int i = 0; i < keyArray.Length; i++)
            {
                keys[i] = keyArray[i];
                values[i] = valueArray[i];
            }
            key = keys[keys.Length - 1];
            value = values[values.Length - 1];
        }

        public int Count
        {
            get { return keys.Length; }
        }

    }
}
