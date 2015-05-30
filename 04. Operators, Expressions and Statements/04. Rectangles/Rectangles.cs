
using System;

class Rectangles
{
    public static void Main()
    {
        float width = float.Parse(Console.ReadLine()); // enter the weight of the rectangle
        float height = float.Parse(Console.ReadLine()); // enter the height of the rectangle

        float perimeter = (height + height) + (width + width); // calculate the perimeter of the rectangle

        Console.WriteLine(perimeter);
    }
}
