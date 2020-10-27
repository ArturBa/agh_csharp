using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab3
{
    struct Point
    {
        double x;
        double y;

        public Point(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public void Reset()
        {
            this.x = this.y = 0;
        }

        public void IncrX(double dx)
        {
            this.x += dx;
        }

        public void IncrY(double dy)
        {
            this.y += dy;
        }

        public void Print2DPoint()
        {
            Console.WriteLine("X: {0:0.00}\tY: {1:0.00}", this.x, this.y);
        }

        public double Dist(Point point)
        {
            return Math.Pow(Math.Pow(this.x - point.x, 2) + Math.Pow(this.y - point.y, 2), .5);
        }
    }
}
