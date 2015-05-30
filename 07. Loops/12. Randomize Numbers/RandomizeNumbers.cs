using System;
using System.Collections.Generic;


class RandomizeNumbers
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        List<int> oldElements = new List<int>(); // this list will consist of ordered elements
        List<int> newElements = new List<int>(); // this list will consist of unordered elements

        for (int i = 1; i <= num; i++)
        {
            oldElements.Add(i); // here we fill the "oldElements" list with elements
        }

        Random rnd = new Random();

        while (newElements.Count < num)
        {

            int index = rnd.Next(oldElements.Count);
            if (newElements.Contains(index + 1))
            {
                continue;
            }
            Console.WriteLine(index + 1);
            newElements.Add(index + 1); // here we fill the "newElements" list with elements
        }
    }
}