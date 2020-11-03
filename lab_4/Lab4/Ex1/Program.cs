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
            ex2();
        }
        
        static void ex1()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            // short a = 0;
            // short b = 0;
            // short c = 0;
            // short d = 0;

            Console.WriteLine("In: {0}", a);
            Fun1(a);
            Console.WriteLine("In: {0}", a);

            Console.WriteLine("Out: {0}", b);
            Fun2(out b);
            Console.WriteLine("Out: {0}", b);

            Console.WriteLine("Ref: {0}", c);
            Fun3(ref c);
            Console.WriteLine("Ref: {0}", c);

            Console.WriteLine("No key word: {0}", d);
            Fun4(d);
            Console.WriteLine("No key word: {0}", d);
            Console.ReadLine();

        }

        static void Fun1(in int i)
        {
            // i = 5;
            // in can be readonly
        }
        static void Fun2(out int i)
        {
            i = 5;
        }
        static void Fun3(ref int i)
        {
            i = 5;
        }
        static void Fun4(int i)
        {
            i = 5;
        }

         public class Point
        {
            public int x, y;
            public Point(int _x, int _y)
            {
                x = _x;
                y = _y;
            }
        }

        static void ex2()
        {
            Point p = null;
            DisplayPoint(p);
            Fun5(p);
            Console.WriteLine("After fun5");
            DisplayPoint(p);

            Fun6(ref p);
            Console.WriteLine("After fun6");
            DisplayPoint(p);

            Console.ReadLine();
        }

        static void DisplayPoint(Point p)
        {
            if(p == null)
            {
                Console.WriteLine("Error while printing a point");
                return;
            }
            Console.WriteLine("x: {0}\ty: {1}", p.x, p.y);
        }

        static void Fun5(Point p)
        {
            Point _p = new Point(5, 5);
            p = _p;
        }

        static void Fun6(ref Point p)
        {
            Point _p = new Point(6, 6);
            p = _p;
        }
    }
}
