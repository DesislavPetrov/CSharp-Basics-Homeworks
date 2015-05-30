using System;
using System.Collections.Generic;

class LongestWordInText
{
    static void Main()
    {
        List<string> sentence = new List<string>(Console.ReadLine().Split(' ')); // enter the sentence and the words are split by space

        int maxLength = 0; // this variable will consist of the value of the length of the longest word
        string maxLengthString = ""; // this variable will consist of the longest word

        for (int i = 0; i < sentence.Count; i++)
        {
            if (sentence[i].Length > maxLength)
            {
                maxLength = sentence[i].Length;
                maxLengthString = sentence[i];
            }
        }

        Console.WriteLine(maxLengthString);
    }
}

