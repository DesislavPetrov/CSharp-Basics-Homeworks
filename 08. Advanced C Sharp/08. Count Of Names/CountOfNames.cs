using System;
using System.Collections.Generic;



class CountOfNames
{
    static void Main()
    {
        List<string> elements = new List<string>(Console.ReadLine().Split(' '));

        elements.Sort(); // we sort the elements of the list

        int count = 1; // we start to count from 1

        for (int i = 1; i < elements.Count; i++)
        {

            if (elements[i] == elements[i - 1])
            {
                count++; // we count the number of the same elements in the list
            }

            else
            {
                Console.WriteLine("{0} -> {1}", elements[i - 1], count); // here we print the previous element with the current counter
                count = 1; // here we restart the counter value from 1
            }
            if (i == elements.Count - 1)
            {
                Console.WriteLine("{0} -> {1}", elements[i], count); // when we reach the last element of the list we print it with the current counter value
            }


        }

    }
}
