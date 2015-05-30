
using System;

class StringsAndObjects
{
    public static void Main()
    {
        string hello = "Hello";
        string world = "World";

        object concatenated = hello + " " + world;

        string concatString = (string)concatenated;

        Console.WriteLine(concatString);
    }
}
