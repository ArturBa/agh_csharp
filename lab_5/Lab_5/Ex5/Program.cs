using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void puts(string s);
        [DllImport("msvcrt.dll")]
        private static extern int _flushall();

        static void Main(string[] args)
        {
            char[] a = "hello there".ToCharArray();
            puts("hello there");
            int flushall = _flushall();
            Console.WriteLine(flushall);

            Console.ReadLine();
        }
    }
}
