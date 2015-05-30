using System;
using System.Numerics;

class CalculateLongerFactorial
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int firstRowFactorial = 1;
        int secondRowFactorial = 1;
        int diffFactorial = 1;

        int result = 0;

        // k is smaller than n, according to the statement of the problem

        for (int i = 1; i <= n; i++)
        {
            firstRowFactorial = firstRowFactorial * i;
            if (i <= k)
            { 
                secondRowFactorial = secondRowFactorial * i;
            }
        }

        for (int i = 1; i <= (n - k); i++)
        {
            diffFactorial = diffFactorial * (i);

        }

        result = (firstRowFactorial) / ((secondRowFactorial) * (diffFactorial));
        Console.WriteLine(result);
    }
}
