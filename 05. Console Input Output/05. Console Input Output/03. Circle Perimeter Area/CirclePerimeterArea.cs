using System;

class CirclePerimeterArea
{
    static void Main()
    {
        Console.WriteLine("Enter the radius");
        float radius = float.Parse(Console.ReadLine());

        float perimeter = (float)((Math.PI) * 2 * radius);
        Console.WriteLine("{0:0.00}", perimeter);

        float area = (float)((Math.PI) * radius * radius);
        Console.WriteLine("{0:0.00}", area);
    }
}
