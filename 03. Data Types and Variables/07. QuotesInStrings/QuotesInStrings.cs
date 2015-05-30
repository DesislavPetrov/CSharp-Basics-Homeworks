
using System;

class QuotesInStrings
{
    public static void Main()
    {
        string quoted = "The \"use\" of quotations causes difficulties.";
        string unquoted = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(quoted);
        Console.WriteLine(unquoted);
    }
}
