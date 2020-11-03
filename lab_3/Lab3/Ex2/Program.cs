using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            b();
            Console.ReadLine();
        }
        
        static void a()
        {
            Point2D p = new Point2D();
            // Console.WriteLine(p.ToString());
        }

        static void b()
        {
            Point2D p = new Point2D();
            Console.WriteLine(p.ToString());
        }
    }
}
