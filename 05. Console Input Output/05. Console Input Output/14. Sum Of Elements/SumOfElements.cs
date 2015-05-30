using System;

class SumOfElements
{
    static void Main()
    {
        string inputLine = Console.ReadLine(); // numbers must be separated one from another by a space
        string[] numbers = inputLine.Split(' ');

        long max = long.MinValue;
        long sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            long element = long.Parse(numbers[i]);
            sum = sum + element;

            if (element > max)
            {
                max = element;
            }
        }

        if (sum == 2 * max) // here we check if the sum is equal to the max value
        {
            Console.WriteLine("Yes, sum=" + max); // 
        }
        else
        {
            long diff = Math.Abs(sum - (2 * max));
            Console.WriteLine("No, diff=" + diff); // here we calculate the difference between the sum and the max value
        }
    }
}

