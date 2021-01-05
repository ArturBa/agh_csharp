using System;
using System.Threading;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(Run).Start();
            Run();
        }

        static void Run()
        {
            for (int cycles = 0; cycles < 5; cycles++)
            {
                Console.Write('x');
            }
        }
    }
}
