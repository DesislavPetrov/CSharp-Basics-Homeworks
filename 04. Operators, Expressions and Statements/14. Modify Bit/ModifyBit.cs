using System;

class ModifyBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine()); // enter the number
        int position = int.Parse(Console.ReadLine()); // enter the position of the bit that you want to check the value
        int bitValue = int.Parse(Console.ReadLine());// enter the value you want to assign to that osition

        if (bitValue == 0) // we assign value 0 to this bit position
        {
            int mask = ~(1 << position);
            int result = number & mask;
            Console.WriteLine(result);
        }
        else // we assign value 1 to this bit position
        {
            int mask = (1 << position);
            int result = (number | mask);
            Console.WriteLine(result);
        }
    }
}

