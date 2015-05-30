using System;


class Program
{
    public static void Main()
    {
        int height = int.Parse(Console.ReadLine()); // enter the height of one block

        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());

        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());

        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());

        int x4 = int.Parse(Console.ReadLine());
        int y4 = int.Parse(Console.ReadLine());

        int x5 = int.Parse(Console.ReadLine());
        int y5 = int.Parse(Console.ReadLine());

        int[] points = new int[] { x1, y1, x2, y2, x3, y3, x4, y4, x5, y5 };

        for (int i = 0; i < points.Length; i += 2)
        {
            if ((points[i] >= 0 && points[i] <= 3 * height && points[i + 1] >= 0 && points[i + 1] <= height) ||
                (points[i] >= height && points[i] <= 2 * height && points[i + 1] >= height && points[i + 1] <= 4 * height))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}