using System;

class Triangle
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
         System.Globalization.CultureInfo.InvariantCulture; // this can be omitted

        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());

        double ab = Math.Sqrt((aX - bX) * (aX - bX) + (aY - bY) * (aY - bY));
        double bc = Math.Sqrt((bX - cX) * (bX - cX) + (bY - cY) * (bY - cY));
        double ac = Math.Sqrt((cX - aX) * (cX - aX) + (cY - aY) * (cY - aY));

        bool areFormingTriangle = (ab + bc > ac && ab + ac > bc && ac + bc > ab);

        if (areFormingTriangle == false) // when the given points can't form a triangle
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", ab); // calculate the length between points A and B
        }
        else // when the given points can form a triangle
        {
            Console.WriteLine("Yes");
            double p = (ab + bc + ac) / 2; // calculate the half of the perimeter
            double area = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac)); // calculate the area
            Console.WriteLine("{0:F2}", area);
        }
    }
}
