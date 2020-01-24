﻿using System;
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
                CopyArray();
            }
            items[count] = value;
            count++;
        }

        public void CopyArray()
        {
            T[] temporaryItems = items;
            items = new T[capacity];
            int index = 0;

            foreach (T item in temporaryItems)
            {
                items[index] = item;
                index++;
            }
        }

        public void Remove(T value)
        {
            T[] temporaryItems = items;
            items = new T[capacity];
            int index = 0;
            int removedItems = 0;

            foreach (T item in temporaryItems)
            {
                if(item.Equals(value) && removedItems == 0)
                {
                    removedItems++;
                    count--;
                    continue;
                }
                items[index] = item;
                index++;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < count; i++)
            {
                sb.Append(items[i]);
            }

            return sb.ToString();
        }

        public static CustomList<T> operator+ (CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> addedList = new CustomList<T>();

            for (int i = 0; i < one.Count; i++)
            {
                addedList.Add(one[i]);
            }

            for (int i = 0; i < two.Count; i++)
            {
                addedList.Add(two[i]);
            }

            return addedList;
        }
    }


}
