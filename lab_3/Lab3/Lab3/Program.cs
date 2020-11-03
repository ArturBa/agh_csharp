using System;
using System.Linq;

namespace Lab3
{

    class Program
    {

        static void Main(string[] args)
        {
            App app = new App();
            app.Main();
        }
    }

    class App
    {
        protected Point2D[] centers;
        protected Point2D point;
        protected double radius = 4;
        protected int centersCnt = 4;

        public App()
        {
            this.centers = new Point2D[this.centersCnt];
        }

        public void Main()
        {
            Console.WriteLine("Gimme 4 2D centers");

            for(int i = 0; i < this.centersCnt; i++)
            {
                this.centers[i] = this.getPointFromConsole();
                this.centers[i].Print2DPoint();
            }

            
            Console.WriteLine("Gimme 2D point");
            this.point = this.getPointFromConsole();

            Boolean givenNegative = false;
            if (!this.isPointInRadius() || givenNegative)
            {
                Console.WriteLine("Point not in a circle");
                Console.WriteLine("Closest point {0:0.00}", this.getClosestCircleDist());
                Console.WriteLine("Gimme another 2D point");

                double x = Double.Parse(Console.ReadLine());
                double y = Double.Parse(Console.ReadLine());

                this.point = new Point2D(x, y);

                if (x < 0 || y < 0 )
                {
                    givenNegative = true;
                }
            } 
            if (givenNegative) 
            {
                for(int i = 0; i < this.centersCnt; i++)
                {
                    this.centers[i].Print2DPoint();

                }
                this.point.Print2DPoint();
            } else
            {
                Console.WriteLine("Point in a circle");
            }


        }

        protected double getClosestCircleDist()
        {
            double[] array = new Double[this.centersCnt];
            for(int i = 0; i < this.centersCnt; i++)
            {
                array[i] = this.centers[i].Dist(this.point);
            }
            return array.Min();
        }

        protected double getDoubleFromConsole()
        {
            double a = Double.Parse(Console.ReadLine());
            return a;
        }

        protected Point2D getPointFromConsole()
        {
            double x = this.getDoubleFromConsole();
            double y = this.getDoubleFromConsole();

            return new Point2D(x, y);
        }

        protected Boolean isPointInRadius()
        {
            for(int i = 0; i < this.centersCnt; i++)
            {
                if (centers[i].Dist(point) < radius)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
