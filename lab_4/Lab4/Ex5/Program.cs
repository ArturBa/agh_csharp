using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 3, 4 };
            foreach (var number in arr.GroupBy(x => x))
            {
                Console.WriteLine(number.Key + " repeats " + (number.Count()) + " times");
            }
            Console.ReadLine();
        }
    }
}
