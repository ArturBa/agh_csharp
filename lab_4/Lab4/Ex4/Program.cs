using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[5];
            for(int i=0; i<5; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            for(int i=4; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
