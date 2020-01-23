using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListBuild
{
    public class CustomList<T>
    {
        T[] items;
        private int count;
        private int capacity;

        public int Count { get => count; }

        public int Capacity { get => capacity; set => capacity = value; }

        //indexer
        public T this[int index]
        {
            get => items[index];

            set => items[index] = value;
        }

        //constructor
        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }

        public void Add(T value)
        {
            if(count == capacity)
            {
                capacity *= 2;
                T[] temporaryItems = items;
                items = new T[capacity];
                int index = 0;

                foreach (T item in temporaryItems)
                {
                    items[index] = item;
                    index++;
                }
            }
            items[count] = value;
            count++;
        }
    }


}
