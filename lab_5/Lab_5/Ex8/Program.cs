using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data_a = new int[] { 1, 1, 2, 2 };
            Matrix a = new Matrix(2, 2, data_a);
            int[] data_b = new int[] { 2, 2, 2, 2 };
            Matrix b = new Matrix(2, 2, data_b);
            int[] data_c = new int[] { 2, 2, 2, 2, 2, 2 };
            Matrix c = new Matrix(2, 3, data_c);
            Console.WriteLine("A matrix");
            a.Print();
            Console.WriteLine("B matrix");
            b.Print();
            Console.WriteLine("Matrix C");
            c.Print();

            Console.WriteLine("B matrix");
            b.Add(10, 1, 1);
            b.Add(20, 1, 2);
            b.Add(30, 2, 1);
            b.Add(40, 2, 2);
            b.Print();

            Console.WriteLine("Sum matrix A + C");
            Matrix sum = a.AddMatrix(c);
            sum.Print();
            Console.WriteLine("Subtract matrix A + C");
            Matrix subtract = a.SubtractMatrix(c);
            subtract.Print();
            Console.ReadLine();
        }
    }
    
    class Matrix
    {
        protected int[,] _matrix;
        int c;
        int l;

        public Matrix(int _c, int _l, int[] matrix_val = null)
        {
            c = _c;
            l = _l;
            _matrix = new int[c, l];
            if (matrix_val != null)
            {
                for(int i=0; i<matrix_val.Length && i<c*l; i++)
                {
                    int column = i / l;
                    _matrix[i % c, column] = matrix_val[i];
                }
            }
        }

        public void Print()
        {
            for(int i=0; i<c; i++)
            {
                for(int j=0; j<l; j++)
                {
                    Console.Write(_matrix[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }

        public int[] Size()
        {
            int[] size = new int[] { c, l };
            return size;
        }

        public void Add(int value, int _c, int _l)
        {
            if (_c <= c &&  _l <= l) {
                _c -= 1;
                _l -= 1;
                _matrix[_c, _l] += value;
            }
        }

        public  int[,] Data()
        {
            int[,] copy2d = _matrix.Clone() as int[,];
            return copy2d;
        }
        public int getValue(int _c, int _l)
        {
            if(_c <= c && _l <= l)
            {
                _c-=1;
                _l-=1;
                return _matrix[_c, _l];
            }
            return 0;
        }
        public Matrix AddMatrix(Matrix matrix)
        {
            int new_c = c > matrix.c ? c : matrix.c;
            int new_l = l > matrix.l ? l : matrix.l;
            Matrix m = new Matrix(new_c, new_l);

            for(int i=1; i<=new_c; i++)
            {
                for(int j=1; j<=new_l; j++)
                {
                    m.Add(getValue(i, j) + matrix.getValue(i, j), i, j);
                }
            }
            return m;
        }

        public Matrix SubtractMatrix(Matrix matrix)
        {
            int new_c = c > matrix.c ? c : matrix.c;
            int new_l = l > matrix.l ? l : matrix.l;
            Matrix m = new Matrix(new_c, new_l);

            for(int i=1; i<=new_c; i++)
            {
                for(int j=1; j<=new_l; j++)
                {
                    m.Add(getValue(i, j) - matrix.getValue(i, j), i, j);
                }
            }
            return m;
        }
    }
}
