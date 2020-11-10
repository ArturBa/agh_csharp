using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            int j = 10;

            if(i > j)
            {
                Console.WriteLine("i > j");
            }
            else
            {
                Console.WriteLine("i > j is unknown");
            }
            if(i == j)
            {
                Console.WriteLine("i = j");
            }
            else
            {
                Console.WriteLine("i = j is unknown");
            }
            if(i < j)
            {
                Console.WriteLine("i < j");
            }
            else
            {
                Console.WriteLine("i < j is unknown");
            }

            Console.ReadLine();

            /**
             * There is no way to campare null value with some real. Null is not treated as 0.
             * All comparisions are false
             */
        }
    }
}
