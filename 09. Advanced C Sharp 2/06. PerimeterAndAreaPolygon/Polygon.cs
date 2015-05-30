using System;
using System.Collections.Generic;


class Polygon
{
    public List<Point> Points { get; set; }

    public Polygon ()
    {
        this.Points = new List<Point>();
    }

    public double GetPerimeter()
    {
        double perimeter = 0;
        for (int i = 1; i < this.Points.Count; i++)
        {
            perimeter += Point.GetLineLength(this.Points[i-1], this.Points[i]);
        }
        perimeter += Point.GetLineLength(this.Points[0], this.Points[this.Points.Count - 1]);

        return perimeter;
    }
}

