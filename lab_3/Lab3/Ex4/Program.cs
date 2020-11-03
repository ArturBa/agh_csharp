using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Program.DayWeek();

            while(true)
            {
                Program.NumberCompare();
            }
        }


        static void DayWeek()
        {

            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Enum.GetName(typeof(WeekDay), day));
        }
        static void NumberCompare()
        {

            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("This number is " +  getNumberSize(number));
        }

        static NumberSize getNumberSize(int number)
        {
            if (number < (int)NumberSize.Small)
            {
                return NumberSize.Small;
            } else if (number < (int)NumberSize.Medium)
            {
                return NumberSize.Medium;
            } 
            return NumberSize.Large;
        }
    }

    enum WeekDay
    {
        Monday = 1,
        Wuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }
    enum NumberSize
    {
        Small = 10,
        Medium = 100,
        Large ,
    }
}
