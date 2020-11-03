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
            int[,] matrix = new int[3, 3] { 
                { 1, 0,-1},
                { 0, 0, 1},
                {-1,-1, 0} 
            };


            Console.WriteLine("Determinant: {0}", Determinant3x3Matrix(matrix));
            Console.ReadLine();
        }

        static double Determinant3x3Matrix(int[,] A)
        {
            double det = 0;
            for (int i = 0; i < 3; i++)
                det += (A[0, i] * (A[1, (i + 1) % 3] * A[2, (i + 2) % 3] - A[1, (i + 2) % 3] * A[2, (i + 1) % 3]));
            return det;
        }

    }
}
