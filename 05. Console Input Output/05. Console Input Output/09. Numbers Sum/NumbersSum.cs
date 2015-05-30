using System;

class NumbersSum
{
    static void Main()
    {
        Console.WriteLine("Enter number \"n\"");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            int nums = int.Parse(Console.ReadLine());
            sum += nums;
        }

        Console.WriteLine(sum);
    }
}

