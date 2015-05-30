
using System;

class ThirdDigit
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine()); // enter the number

        bool thirdDigit = (((number / 100) % 10) == 7); // we check if the third digit from right to left is 3

        Console.WriteLine(thirdDigit);
    }
}
