using System;
using System.Linq;


class CountingWordInText
{
    static void Main()
    {
        string word = Console.ReadLine(); // enter the word, for which we will search for
        string text = Console.ReadLine(); // enter the text, into which we will search for

        foreach (var element in text)
        {
            if (!Char.IsLetter(element))
            {
                text = text.Replace(element, ' ');
            }
        }

        string[] textArray = text.Split(' ');
        string wordToLower = word.ToLower();

        int count = textArray.Count(w => w.ToLower() == wordToLower);

        Console.WriteLine(count);
    }
}