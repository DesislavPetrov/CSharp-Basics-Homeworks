using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Point
{
    public int X { get; set; } // property
    public int Y { get; set; } // property

    public Point (int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void PrintPoint()
    {
        Console.WriteLine("x: {0}, y: {1}", this.X, this.Y);
    }
    
    public static double GetLineLength(Point p1, Point p2)
    {
        return Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
    }
}
