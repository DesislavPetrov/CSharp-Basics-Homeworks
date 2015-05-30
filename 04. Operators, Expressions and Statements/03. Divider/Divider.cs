
using System;

class Divider
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine()); // enter your number you want to check
        bool divider = ((number % 5 == 0) && (number % 7 == 0)); // here we check if the number is divided to 7 and 5 at the same time

        Console.WriteLine(divider);
    }
}
