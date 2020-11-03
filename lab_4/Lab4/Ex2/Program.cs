using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        public unsafe static void Main()
        {
            ex3();
        }

        public unsafe static void ex3()
        {
            int[] buffer = new int[1024];

            fixed (int* buf = buffer)
            {
                for (int i = 0; i < 1024; i++)
                {
                    *(buf + i) = i;
                    Console.WriteLine("Value: {0}", *(buf + i));
                }
            }
            Console.ReadLine();
        }


        public unsafe static void ex2()
        {
            int a = 6;
            int b = 16;
            Console.WriteLine("A: {0}\tB: {1}", a, b);
            swap(&a, &b);
            Console.WriteLine("A: {0}\tB: {1}", a, b);
            Console.ReadLine();
        }
        public unsafe static void swap(int* p, int* q)
        {
            int temp = *q;
            *q = *p;
            *p = temp;
        }

        public unsafe static void ex1()
        {

            int[] list = { 10, 100, 200 };
            fixed (int* ptr = list)
            {

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Address: [{0}]={1}", i, (int)(ptr + i));
                    Console.WriteLine("Value: [{0}]={1}", i, *(ptr + i));
                }
            }

            Console.ReadLine();
        }

    }
}
