using System;

class NumbersOneToN
{
    static void Main()
    {
        Console.WriteLine("Enter number \"n\"");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

