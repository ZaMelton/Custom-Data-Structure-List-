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
            List<int> numList = new List<int>() { 1,2,3,4,5,6};

            Console.WriteLine(numList.IndexOf(0)); 
            Console.ReadLine();
        }
    }
}
