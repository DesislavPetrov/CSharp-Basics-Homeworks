using System;

class CheckBitAtPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()); // enter the number
        int position = int.Parse(Console.ReadLine()); // enter the position of the bit that you want to check the value

        int mask = number >> position;
        int bitValue = mask & 1;

        bool isOne = (bitValue == 1);

        Console.WriteLine(isOne);
    }
}

