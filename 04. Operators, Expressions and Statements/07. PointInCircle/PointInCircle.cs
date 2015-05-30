
using System;

class PointInCircle
{
    public static void Main()
    {
        float x = float.Parse(Console.ReadLine()); // enter the X coordinate
        float y = float.Parse(Console.ReadLine()); // enter the Y coordinate

        float dist = (float)(Math.Sqrt((x * x) + (y * y))); // check the hypotenuse in isosceles triangle
        bool inCircle = (dist <= 2); // check if this hypotenuse is shorter than 2

        Console.WriteLine(inCircle);
    }
}
