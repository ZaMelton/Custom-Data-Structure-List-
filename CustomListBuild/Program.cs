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
            CustomList<int> numbers = new CustomList<int>() {3,2,5,4,6,7,8,5,6,1,1,1,5,4,6};

            CustomList<int>.BubbleSort(numbers);
            Console.WriteLine(numbers);
            Console.ReadLine();
        }
    }
}
