
using System;

class Trapezoids
{
    public static void Main()
    {
        float a = float.Parse(Console.ReadLine()); // enter the length of side "a"
        float b = float.Parse(Console.ReadLine()); // enter the length of side "b"
        float h = float.Parse(Console.ReadLine()); // enter the length of side "h"

        float area = (a + b) / 2 * h; // calculate the area of the trapezoid

        Console.WriteLine(area);
    }
}
