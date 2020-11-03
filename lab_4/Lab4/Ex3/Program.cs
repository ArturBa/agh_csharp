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
            string[] arr = new string[10];
            while (true)
            {
                string newValue = Console.ReadLine();
                for(int i = 0; i<10; i++)
                {
                    string oldValue = arr[i];
                    arr[i] = newValue;
                    newValue = oldValue;
                }
                foreach(string value in arr){
                    Console.WriteLine(value);
                }
            }
        }
    }
}
