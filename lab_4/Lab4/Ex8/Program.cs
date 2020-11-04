using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            A();
            B();
            Console.ReadLine();
        }

        static void B()
        {
            int[][] arrOfArr = {
                new int[]{ 1, 2, 3},
                new int[]{ 4, 5, 6, 7, 8, 9 },
                new int[]{ 10, 11, 12, 13 },
                new int[]{ 14, 15, 16, 17, 18 },
                new int[]{ 19, 20, 21 } 
            };

            ArrayDisplay(arrOfArr);
        }

        static void A()
        {
            int[][] arrOfArr = new int[5][];
            arrOfArr[0] = new int[3] { 1, 2, 3};
            arrOfArr[1] = new int[6] { 4, 5, 6, 7, 8, 9} ;
            arrOfArr[2] = new int[4] { 10, 11, 12, 13 };
            arrOfArr[3] = new int[5] { 14, 15, 16, 17, 18 };
            arrOfArr[4] = new int[3] { 19, 20, 21 };

            ArrayDisplay(arrOfArr);
        }

        static void ArrayDisplay(int[][] arrOfarr)
        {
            foreach(int[] arr in arrOfarr)
            {
                foreach(int x in arr)
                {
                   Console.Write("{0} ", x);
                }
                Console.Write("\n");
            }
        }

    }
}
