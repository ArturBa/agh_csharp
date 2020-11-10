using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 i = 23;
            object o = i;
            i = 123;
            Console.WriteLine(i + ", " + (Int32)o);
            /**
             * 1. Spakowany obiekt używa innej instancji pamięci niż obiekt
             */

            // long j = (long)o;
            /**
             * 2. 
             * Specified cast is not valid
             * Nieprawidłowy typ odpakowaonaego obiektu
             */

            Console.ReadLine();
        }
    }
}
