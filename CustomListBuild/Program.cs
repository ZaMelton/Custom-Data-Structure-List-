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
        }
    }
}
