using System;

namespace Aplikacja2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum2(8, 2);
            Divide2(8, 2);
            Operations();
        }

        static void Sum2(float a, float b)
        {
            Console.WriteLine(a + b);
        }

        static void Divide2(float a, float b)
        {
            Console.WriteLine(a / b);
        }

        static void Operations()
        {
            float a = -1 + 4 * 6;
            float b = (35 + 5) % 7;
            float c = 14 + (-4) * 6 / 11;
            float d = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine(a + " " + b + " " + c + " " + d);
        }
    }
}
