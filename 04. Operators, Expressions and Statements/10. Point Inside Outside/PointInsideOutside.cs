
using System;

class PointInsideOutside
{
    public static void Main()
    {
        float x = float.Parse(Console.ReadLine()); // enter the X coordinate
        float y = float.Parse(Console.ReadLine()); // enter the Y coordinate

        float hypotenuse = (float)(Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1)))); // calculate the hypotenuse

        if ((x >= (-0.5)) && (x <= 2.5) && (hypotenuse <= 1.5)) // check if the point is within the circle and outside the rectangle
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

