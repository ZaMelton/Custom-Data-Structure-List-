using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomListBuild
{
   public class CustomList<T> : IEnumerable where T : IComparable
    {
        T[] items;
        private int count;
        private int capacity;

        public int Count { get => count; }

        public int Capacity { get => capacity; set => capacity = value; }

        //indexer
        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }

            set 
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            } 
        }

        //Iterator
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        //constructor
        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;
        }

        public CustomList(int capacity)
        {
            this.capacity = capacity;
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

        public bool Remove(T value)
        {
            T[] temporaryItems = items;
            items = new T[capacity];
            int index = 0;
            bool removedItems = false;

            foreach (T item in temporaryItems)
            {
                if(item != null)
                {
                    if (item.Equals(value) && removedItems == false)
                    {
                        removedItems = true;
                        count--;
                        continue;
                    }
                    items[index] = item;
                    index++;
                }
            }
            return removedItems;
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

        public static CustomList<T> operator- (CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> minusedList = new CustomList<T>();

            for (int i = 0; i < one.Count; i++)
            {
                minusedList.Add(one[i]);
            }

            for (int i = 0; i < two.Count; i++)
            {
                minusedList.Remove(two[i]);
            }
            return minusedList;
        }

        public static CustomList<T> Zip(CustomList<T> first, CustomList<T> second)
        {
            CustomList<T> zipped = new CustomList<T>();

            int indexOne = 0;
            int indexTwo = 0;

            int lengthOfListsCombined = first.Count + second.Count;

            for (int i = 0; i < lengthOfListsCombined; i++)
            {
                if (first.Count > indexOne)
                {
                    zipped.Add(first[indexOne]);
                    indexOne++;
                }

                if (second.Count > indexTwo)
                {
                    zipped.Add(second[indexTwo]);
                    indexTwo++;
                }
            }
            return zipped;
        }

        public static void BubbleSort(CustomList<T> listToSort)
        {
            T temp;
            for (int i = 0; i < listToSort.Count - 1; i++)
            {
                for (int j = 0; j < listToSort.Count - 1; j++)
                {
                    if (listToSort[j].CompareTo(listToSort[j + 1]) == 1)//Check for greater than
                    {
                        temp = listToSort[j];
                        listToSort[j] = listToSort[j + 1];
                        listToSort[j + 1] = temp;
                    }
                }
            }
        }

        public static void SelectionSort(CustomList<T> listToSort)
        {
            T minValue;
            int index;

            for (int i = 0; i < listToSort.Count - 1; i++)
            {
                index = i;
                minValue = listToSort[i];

                for(int j = i; j < listToSort.Count; j++)
                {
                    if(listToSort[j].CompareTo(minValue) == -1)
                    {
                        minValue = listToSort[j];
                        index = j;
                    }
                }
                listToSort[index] = listToSort[i];
                listToSort[i] = minValue;
            }
        }

        public bool Contains(T value)
        {
            for(int i = 0; i < count; i++)
            {
                if (items[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].CompareTo(value) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int insertIndex, T value)
        {
            T[] temp = new T[capacity *= 2];

            for (int i = 0, j = 0; i < count; i++, j++)
            {
                if (j == insertIndex)
                {
                    temp[j] = value;
                    i--;
                }
                else
                {
                    temp[j] = items[i];
                } 
            }
            count++;
            items = temp;
        }

        public void RemoveRange(int startIndex, int amountToRemove)
        {
            T[] temporaryItems = items;
            items = new T[capacity];
            int itemsSkipped = 0;

            if(startIndex + amountToRemove > count || startIndex < 0 || startIndex > count)
            {
                throw new ArgumentOutOfRangeException();
            }

            for(int i = 0, j = 0; i < count; i++, j++)
            {
                if(temporaryItems[i] != null)
                {
                    if(j == startIndex)
                    {
                        if(itemsSkipped != amountToRemove)
                        {
                            itemsSkipped++;
                            j--;
                            continue;
                        }
                    }
                    items[j] = temporaryItems[i];
                }
            }
            count -= amountToRemove;
        }
    }
}
