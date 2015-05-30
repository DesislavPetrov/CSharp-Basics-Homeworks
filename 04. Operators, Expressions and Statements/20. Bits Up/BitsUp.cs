
using System;

class BitsUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // enter the number of bytes
        int step = int.Parse(Console.ReadLine()); // enter the step

        int index = 0; // here bits in each byte are counted from the leftmost to the rightmost and bits are numbered starting from 0

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine()); // enter the byte
            for (int bit = 7; bit >= 0; bit--)
            {
                if ((index % step == 1) || (step == 1 && index > 0))
                {
                    number = number | (1 << bit); // here we use the mask
                }
                index++;
            }
            Console.WriteLine(number);

        }
    }
}
