using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static double[,] matrixA = new double[,]
        {
            { 2, 2},
            { 2, 2},
        };
        static double[,] matrixB = new double[,]
        {
            { 2 },
        };
        static double[,] matrixC = new double[,]
        {
            { 2, 2, 2},
            { 2, 2, 2},
            { 2, 2, 2},
        };
        static double[,] matrixD = new double[,]
        {
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
        };
        static double[,] matrixE = new double[,]
        {
            { 0, 2},
            { 2, 0},
        };
        static double[][,] matrixes = new double[][,]
        {
            matrixA,
            matrixB,
            matrixC,
            matrixD,
            matrixE,
        };

        static void Main(string[] args)
        {
            int numMatrix = matrixes.Length;
            Task<double>[] output = new Task<double>[numMatrix];
            for (int i = 0; i<numMatrix; i++)
            {
                  output[i] = Task.Factory.StartNew(new Func<object, double>(sumMatrix), matrixes[i]);
            }
            Task.WaitAll(output);

            double total = 0;
            for (int i = 0; i<numMatrix; i++)
            {
                total += output[i].Result;
            }
            Console.WriteLine("Total: {0}", total);
        }

        static double sumMatrix(object mat)
        {
            double sum = 0;
            double[,] matrix = (double[,])mat;
            foreach(double i in matrix)
            {
                sum += i;
            }
            return sum;
        }
    }
}
