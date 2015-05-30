using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number \"a\" between 0 and 500");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a float number \"b\"");
        float b = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter a float number \"c\"");
        float c = float.Parse(Console.ReadLine());

        Console.Write("{0,-10:X}|", a);
        Console.Write(Convert.ToString(a, 2).PadLeft(10, '0') + "|");
        Console.Write("{0,10:0.00}|", b);
        Console.WriteLine("{0,-10:0.000}|", c);
    }
}
