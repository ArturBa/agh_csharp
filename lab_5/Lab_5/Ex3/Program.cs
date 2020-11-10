using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            int? a = null;
             Console.WriteLine(a);
            /*
             * 1. Null print
             */

            // 2
            // int? a = null;
            Console.WriteLine(a.GetValueOrDefault(12));
            Console.WriteLine(a.HasValue);
            /*
             * Printed default value (12)
             * a has no value
             */

            // 3
            a = 5;
            Console.WriteLine(a);
            


            Console.ReadLine();
        }
    }
}
