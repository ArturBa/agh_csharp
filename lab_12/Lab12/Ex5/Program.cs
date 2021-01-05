using System;
using System.Threading;

namespace Ex5
{
    class Program
    {
        static bool done;
        static readonly object locker = new object();
        static void Main(string[] args)
        {
            new Thread(Run).Start();
            Run();
        }
        static void Run()
        {
            lock(locker)
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
}
