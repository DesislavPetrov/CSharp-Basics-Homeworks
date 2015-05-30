using System;


class Pairs
{
    public static void Main()
    {
        string inputLine = Console.ReadLine(); // numbers must be separated one from another by a space
        string[] numbers = inputLine.Split(' ');

        int elementOne = int.Parse(numbers[0]);
        int elementTwo = int.Parse(numbers[1]);
        int prevValue = elementOne + elementTwo;

        int maxDiff = 0;

        for (int i = 2; i < numbers.Length; i += 2)
        {
            elementOne = int.Parse(numbers[i]);
            elementTwo = int.Parse(numbers[i + 1]);
            int lastValue = elementOne + elementTwo;
            int diff = Math.Abs(lastValue - prevValue);
            maxDiff = Math.Max(diff, maxDiff);
            prevValue = lastValue;

        }

        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value={0}", prevValue);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}
