using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[,]
            {
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
                {1, 1, 1, 1, 1},
            };
            int[,] matrixB = new int[,]
            {
                {2, 2, 2, 2, 2},
                {2, 2, 2, 2, 2},
                {2, 2, 2, 2, 2},
                {2, 2, 2, 2, 2},
                {2, 2, 2, 2, 2},
            };

            int[,] result = sumMatrix(matrixA, matrixB);

            Console.WriteLine("Length: {0}, Rank: {1}, LongLenght: {2}", result.Length, result.Rank, result.LongLength);
            Console.ReadLine();
        }

        static int[,] sumMatrix(int[,] A, int[,] B)
        {
            int[,] sum = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sum[i, j] = A[i, j] + B[i, j];
                }

            }
            return sum;
        }
    }
}
