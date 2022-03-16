using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<T,K>
    {
        T[] keyArray;
        K[] valueArray;
        public MyDictionary()
        {
            keyArray = new T[0];
            valueArray = new K[0];

        }

        public void Add(T key,K value)
        {            
            T[] tempKeyArray = keyArray;
            keyArray = new T[keyArray.Length + 1];
            K[] tempValueArray = valueArray;
            valueArray = new K[valueArray.Length + 1];


            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                tempKeyArray[i] = keyArray[i];
            }
            keyArray[keyArray.Length - 1] = key;

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                tempValueArray[i] = valueArray[i];
            }
            valueArray[valueArray.Length - 1] = value;
        }
        public int Count
        {
            get { return keyArray.Length; }           
        }

        
    }
}
