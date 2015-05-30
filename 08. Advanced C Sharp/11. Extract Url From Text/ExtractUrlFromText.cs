using System;
using System.Collections.Generic;
using System.Linq;

class ExtractUrlsFromText
{
    static void Main()
    {
        string rawString = Console.ReadLine();
        var links = rawString.Split("\t\n ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Where(s => s.StartsWith("http://") || s.StartsWith("www.") || s.StartsWith("https://"));
        foreach (string s in links)
        {
            Console.WriteLine(s);
        }

    }

}
