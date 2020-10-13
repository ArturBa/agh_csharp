using System;

namespace Aplikacja4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 0, 0, 0 };
            for(int i=0; i < 3; i++)
            {
                values[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Iloczyn: {0} x {1} x {2} = {3}", values[2], values[1], values[0], values[0]*values[1]*values[2]);
        }
    }
}
