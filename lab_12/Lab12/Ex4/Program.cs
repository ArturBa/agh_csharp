using System;
using System.Threading;

namespace Ex4
{
    class Program
    {
        static bool done;
        static void Main(string[] args)
        {
            new Thread(Run).Start();
            Run();
        }
        static void Run()
        {
            if (!done)
            {
                // done = true;
                Console.WriteLine("Done");
                done = true;
            }
        }
    }

}
