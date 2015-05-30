
using System;

class Rectangles
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine()); // enter the number

        bool isDivide = ((number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0)) && (number != 1);
        // check if the number is prime

        Console.WriteLine(isDivide);
    }
}
