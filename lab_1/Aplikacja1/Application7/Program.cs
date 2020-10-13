using System;

namespace Application7
{
    class Program
    {
        static void Main(string[] args)
        {
            float celcius = float.Parse(Console.ReadLine());
            Console.WriteLine("C: {0}, K: {1}, F: {2}", celcius, ToKelvin(celcius), ToFarenheit(celcius));
        }
        static double ToFarenheit(double celcius)
        {
            return celcius * 18 / 10 + 32;
        }
        static double ToKelvin(double celcius)
        {
            return celcius + 273;
        }
    }
}
