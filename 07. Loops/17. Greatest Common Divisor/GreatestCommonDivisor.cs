
using System;


class GreatestCommonDivisor
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int minNumber = Math.Min(a, b);
        int greatestCommonDivisor = 1;

        for (int i = 1; i <= minNumber; i++)
        {
            if ((a % i == 0) && (b % i == 0))
            {
                greatestCommonDivisor = i;
            }
        }

        Console.WriteLine(greatestCommonDivisor);
    }
}
