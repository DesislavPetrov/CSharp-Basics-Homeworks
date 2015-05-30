using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MainClass
{
    public static void Main()
    {
        Polygon poly = new Polygon();

            poly.Points.Add(new Point(10, 20));
            poly.Points.Add(new Point(2, 20));
            poly.Points.Add(new Point(10, 3));
        

        Console.WriteLine(poly.GetPerimeter());
    }
}

