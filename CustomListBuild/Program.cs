using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> sortedArray = new CustomList<string>();

            sortedArray.Add("Hi");

            Type t = sortedArray[0].GetType();

            Console.WriteLine(sortedArray[0].GetType());

            if (t.Equals(typeof(string)))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            List<int> numbers = new List<int>() { 3, 2, 6, 1, 7 };

            int temp;
            for (int i = 0; i < numbers.Count - 2; i++)
            {
                for(int j = 0; j < numbers.Count - 2; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                    }
                }
            }



            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            int[] nums = new int[5] { 1,4,3,6,9};


            Array.Sort(nums);

            foreach(int num in nums)
            {
                Console.WriteLine(  num);
            }

            Console.ReadLine();
        }
    }
}
