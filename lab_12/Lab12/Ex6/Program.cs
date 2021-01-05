using System;
using System.Threading;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Run);
            t.Start();
            // t.Join();
            Console.WriteLine("Thread t has ended");
        }

        static void Run()
        {
            for (int i = 0; i < 777; i++)
            {
                Console.Write("o");
            }
        }
    }
}
