using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,V>
    {
        T[] items;
        V[] values;
        public MyDictionary()
        {
            items = new T[0];
            values = new V[0];
        }

        public void Add(T item, V value)
        {
            T[] tempArray = items;
            V[] tempValue = values;

            items = new T[items.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = items[i];
            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                tempValue[i] = values[i];
            }

            items[items.Length - 1] = item;
            values[values.Length - 1] = value;

            Console.WriteLine("item: [" + item + "] " + " value : [" + value + "]");

        }
        public int LengthItems
        {
            get { return items.Length; }
        }

        public int LengthValues
        {
            get { return values.Length; }
        }
    }
}
