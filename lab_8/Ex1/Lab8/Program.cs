using System;
using System.Linq;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            ICepikData[] cepikData = { new Auto(), new Auto() };
            IPoliceData[] policeData = { new Auto(), new Auto() };
            IStatData[] statData = { new Auto(), new Auto() };


            foreach(ICepikData cepik in cepikData)
            {
                Console.WriteLine(cepik.address());
            }
            foreach(IStatData stat in statData)
            {
                Console.WriteLine(stat.marka());
            }
            foreach(IPoliceData police in policeData)
            {
                Console.WriteLine(police.points());
            }
            Point p = 5;
            Point r = new Point(1, 2);
            int suma = (int)r;
            Console.WriteLine(suma);

            f GetF = Foo.Sum;
            int sum = GetF(1, 2);
            GetF = Foo.Sub;
            int sub = GetF(1, 2);
        }
    }

    interface ICepikData
    {
        string typ();
        string marka();
        double pojemnosc();
        int liczba_miejsc();
        string name();
        string address();
        int PESEL();
        string driving_licence();
        DateTime driving_exam();
        int purchase_year();
    }
    interface IStatData
    {
        string typ();
        string marka();
        double pojemnosc();
        int liczba_miejsc();
    }
    interface IPoliceData
    {
        string typ();
        string marka();
        double pojemnosc();
        int liczba_miejsc();
        string name();
        string address();
        int PESEL();
        string driving_licence();
        DateTime driving_exam();
        int purchase_year();
        int points();
    }

    class Auto : ICepikData, IPoliceData, IStatData
    {
        Car car = new Car();
        Owner owner = new Owner();

        public string typ()
        {
            return car.typ;
        }
        public string marka()
        {
            return car.marka;
        }
        public double pojemnosc()
        {
            return car.pojemnosc;
        }
        public int liczba_miejsc()
        {
            return car.liczba_miejsc;
        }

        public string name()
        {
            return owner.name;
        }
        public string address()
        {
            return owner.address;
        }
        public int PESEL()
        {
            return owner.PESEL;
        }
        public string driving_licence()
        {
            return owner.driving_licence;
        }
        public DateTime driving_exam()
        {
            return owner.driving_exam;
        }
        public int purchase_year()
        {
            return owner.purchase_year;
        }
        public int points()
        {
            return owner.points;
        }


        class Car
        {
            public string typ = RandomString(3);
            public string marka = RandomString(3);
            public double pojemnosc = 4.0;
            public int liczba_miejsc = 2;
            public double police = 321312;
        }

        class Owner
        {
            public string name = RandomString(5);
            public string address = RandomString(5);
            public int PESEL = 0123456789;
            public string driving_licence = RandomString(5);
            public DateTime driving_exam = new DateTime(2414124);
            public int purchase_year = 1990;
            public int points = 4;
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }


    /**
     * EX 2
     */

    public class Point
    {
        public int x, y;
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        void print()
        {
            Console.WriteLine("X: {0}\tY: {1}", x, y);
        }

        public static Point operator +(Point a, Point b) => new Point(a.x * b.x, a.y + b.y);

        public static implicit operator bool(Point p) => p.x == 0 && p.y == 0;

        public static bool operator ==(Point a, Point b) => a.x == b.x && a.y == b.y;
        // Requires also !=
        public static bool operator !=(Point a, Point b) => a.x != b.x || a.y != b.y;

        public static bool operator <(Point a, Point b) => a.x < b.x && a.y < b.y;
        // Requires also >
        public static bool operator >(Point a, Point b) => a.x > b.x && a.y > b.y;
        public static bool operator <=(Point a, Point b) => a.x <= b.x && a.y <= b.y;
        // Requires also >=
        public static bool operator >=(Point a, Point b) => a.x >= b.x && a.y >= b.y;
        public static Point operator ++(Point a)
        {
            a.x++;
            a.y++;
            return a;
        }
        public static Point operator --(Point a)
        {
            a.x--;
            a.y--;
            return a;
        }

        public static implicit operator Point(int b) => new Point(b, 0);
        // public static implicit operator int(Point d) => d.x + d.y;
        public static explicit operator int(Point d) {
            return d.x + d.y;
        }


        // Cannot override +=
        // public static Point operator +=(Point a) { }
    }


    /**
     * EX 3
     */

    public delegate int f(int x, int y);

    static class Foo
    {
        static public int Sum(int x, int y)
        {
            Console.WriteLine("Sum: {0}", x + y);
            return x + y;
        }
        static public int Sub(int x, int y)
        {
            int result = x - y;
            Console.WriteLine("Sub: {0}", result);
            return result;
        }
        static public int Mul(int x, int y)
        {
            int mul = x * y;
            Console.WriteLine("Sum: {0}", mul);
            return mul;
        }
        static public int Dev(int x, int y)
        {
            Console.WriteLine("Sum: {0}", x / y);
            return x / y;
        }
    }

}
