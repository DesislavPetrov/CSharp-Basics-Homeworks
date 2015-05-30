
using System;


class RandomNumbersInRange
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random round = new Random();

        for (int i = 0; i < n; i++)
        {
            int randomNumber = round.Next(min, max);

            Console.WriteLine(randomNumber);
        }
    }
}
