
using System;

class OddOrEven
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine()); // enter your number you want to check
        bool even = (number % 2 != 0); // here we check if the number is odd

        Console.WriteLine(even);
    }
}