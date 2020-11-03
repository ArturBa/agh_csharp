using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    public struct Coords
    {
        public int x, y;
        public Coords(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Print()
        {
            Console.WriteLine("X: {0}\tY: {1}", x, y);
        }
    }

    public class Point
    {
        public int x, y;
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public void Print()
        {
            Console.WriteLine("X: {0}\tY: {1}", x, y);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 1);
            Coords c = new Coords(1, 1);

            p.Print();
            Fun1(p); 
            p.Print();

            c.Print();
            Fun2(c);
            c.Print();

            Console.ReadLine();

        }

        static void Fun1(Point p)
        {
            p.x = p.y = 4;
        }

        static void Fun2(Coords c)
        {
            c.x = c.y = 4;
        }
    }
}
