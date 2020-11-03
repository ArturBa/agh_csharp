using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (char i in input)
            {
                Console.Write("{0} ", i);
            }
            Console.ReadKey();
        }
    }
}
