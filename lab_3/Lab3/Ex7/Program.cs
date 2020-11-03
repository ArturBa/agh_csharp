using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // int overflown = Int32.MaxValue  + 1;
                int maxValue = Int32.MaxValue;
                checked
                {
                    maxValue++;
                }
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine("Exception {0} caught", ex.GetType());
            }
        }
    }
}
