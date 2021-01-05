using System;
using System.Threading;

namespace Ex3
{
    class Program
    {
        bool done;
        static void Main()
        {
            Program pp = new Program();
            new Thread(pp.Run).Start();
            pp.Run();
        }

        void Run()
        {
            if (!done)
            {
                done = true;
                Console.WriteLine("Done");
            }
        }
    }
}
