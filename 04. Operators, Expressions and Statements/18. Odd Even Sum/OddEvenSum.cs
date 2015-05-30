using System;

class OddEvenSum
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // enter the number of the digits/2
        int evenSum = 0;
        int oddSum = 0;

        for (int pos = 1; pos <= n * 2; pos++)
        {
            int number = int.Parse(Console.ReadLine()); // enter each number
            if (pos % 2 == 0) // check if the number is even
            {
                evenSum = evenSum + number;
            }
            else // check if the number is odd
            {
                oddSum = oddSum + number;
            }

        }


        int diff = Math.Abs(evenSum - oddSum);
        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes, sum={0}", evenSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}
