
using System;
using System.Collections.Generic;


class RemoveNames
{
    public static void Main()
    {
        List<string> firstList = new List<string>(Console.ReadLine().Split(' '));
        List<string> secondList = new List<string>(Console.ReadLine().Split(' '));


        for (int i = 0; i < firstList.Count; i++)
        {
            for (int j = 0; j < secondList.Count; j++)
            {
                if (firstList[i] == secondList[j])
                {
                    firstList.Remove(firstList[i]);
                    j = (-1); // here we reset the "j" value to zero
                }
                if (i == firstList.Count)
                {
                    break;
                }
            }
        }

        foreach (var el in firstList)
        {
            Console.Write("{0} ", el);
        }
        Console.WriteLine();
    }
}
