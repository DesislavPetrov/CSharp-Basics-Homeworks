using System;


class CalculateFactorialDivision
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int firstRowFactorial = 1;
        int secondRowFactorial = 1;

        int result = 0;

        // k is smaller than n, accroding to the statement of the problem

        for (int i = 1; i <= n; i++)
        {
            firstRowFactorial = firstRowFactorial * i;
            if (i <= k)
            {
                secondRowFactorial = secondRowFactorial * (i);
            }
        }

        result = (firstRowFactorial) / (secondRowFactorial);
        Console.WriteLine(result);
    }
}
