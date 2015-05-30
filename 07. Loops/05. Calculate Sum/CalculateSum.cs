using System;


class CalculateSum
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        int factorial = 1;
        double result = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
            result = result + (factorial / (Math.Pow(x, i)));
        }

        Console.WriteLine("{0:F5}", result);
    }
}
