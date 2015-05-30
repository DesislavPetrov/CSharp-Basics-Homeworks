using System;

class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // enter the number of the elements

        string lastString = Console.ReadLine(); // here we'll keep the last enetered string
        string currString; // here we'll keep the current entered string
        string longestString = lastString; // here we'll keep the string that is part of the longest sequence of equal strings

        int currentSequence = 1; // the counter for current sequence of strings
        int longestSequence = 1; // the counter of the longest sequence of strings

        for (int i = 1; i < n; i++)
        {
            currString = Console.ReadLine();

            if (currString == lastString)
            {
                currentSequence++;
                if (currentSequence > longestSequence)
	            {
		                longestSequence = currentSequence;
                        longestString = currString;
	            }
            }
            else
            {
                currentSequence = 1;
            }
            lastString = currString;
        }

        Console.WriteLine(longestSequence);
        for (int i = 0; i < longestSequence; i++)
        {
            Console.WriteLine(longestString); // // print the string that is part of the longest sequence of equal strings
        }
    }
}

