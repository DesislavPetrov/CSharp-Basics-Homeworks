
using System;
using System.Globalization;
using System.Threading;


class ComparingFloats
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double eps = 0.000001D;


        bool isEqual = ((Math.Abs(a - b)) < eps);

        Console.WriteLine(isEqual);
    }
}
