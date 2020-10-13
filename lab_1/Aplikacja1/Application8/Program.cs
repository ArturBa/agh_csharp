using System;

namespace Application8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is negative and positive: " + NegAndPos().ToString());
        }
        static bool NegAndPos()
        {
            return double.Parse(Console.ReadLine()) * double.Parse(Console.ReadLine()) < 0;
        }
    }
}
