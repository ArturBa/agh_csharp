using System;

namespace Aplikacja6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 75400;
            double ii = 7.54;
            Console.WriteLine("Wartość int to {0}, a wartość double to {1}", i, ii);

            Console.WriteLine("Wartość int to " + i + ", a wartość double to " + ii.ToString());

            Console.WriteLine("--{0, 40}--{1, 40}--", i, ii);
            Console.WriteLine("--{0, -40}--{1, -40}--", i, ii);

            Console.WriteLine("{0:c}, {0:d}, {0:e}, {0:f}, {0:x}", i);
            Console.WriteLine("{0:c}, {0:e}, {0:f}, {0:r}", ii);
            // Console.WriteLine("{0:c}, {0:d}, {0:e}, {0:f}, {0:r}, {0:o}, {0:x}", i);

            float flo = 220.022f;
            Console.WriteLine("{0:0.00000}, {0:[#].(#)(##)}, {0:0.0}, {0:0,0},  {0:,.},  {0:0%}, {0:0e+0}", flo);

            double a = 123.4;
            Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", a);

            a = -1234;
            Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", a);

            a = 0;
            Console.WriteLine("{0:#,##0.0;(#,##)Minus;Zero}", a);

            DateTime d = System.DateTime.Now;

            Console.WriteLine("{0:d}", d);
            Console.WriteLine("{0:D}", d);
            Console.WriteLine("{0:t}", d);
            Console.WriteLine("{0:T}", d);
            Console.WriteLine("{0:f}", d);
            Console.WriteLine("{0:F}", d);
            Console.WriteLine("{0:g}", d);
            Console.WriteLine("{0:G}", d);
            Console.WriteLine("{0:M}", d);
            Console.WriteLine("{0:r}", d);
            Console.WriteLine("{0:s}", d);
            Console.WriteLine("{0:u}", d);
            Console.WriteLine("{0:U}", d);
            Console.WriteLine("{0:Y}", d);
        }
    }
}
