using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());
            A(input);
            B(input);
            Console.ReadLine();
        }

        static void A(int input)
        {
            for(int i=1; i <= input; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write(j + 1);
                }
                Console.Write('\n');
            }
        }

        static void B(int input)
        {
            for(int i=1; i <= input; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write(i);
                }
                Console.Write('\n');
            }
        }
    }
}
