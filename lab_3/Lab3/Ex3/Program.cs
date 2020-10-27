using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int stringConv = 0, doubleConv = 0, intConv = 0;

            string input = "";
            while (input != "-1")
            {
                input = Console.ReadLine();
                try
                {
                    Convert.ToString(input);
                    stringConv++;
                } catch {}
                try
                {
                    Convert.ToInt32(input);
                    intConv++;
                } catch {}
                try
                {
                    Convert.ToDouble(input);
                    doubleConv++;
                } catch {}
            }
            Console.WriteLine("String: {0}\tDouble: {1}\tIntiger: {2}", stringConv, doubleConv, intConv);
            Console.ReadKey();
        }
    }
}
