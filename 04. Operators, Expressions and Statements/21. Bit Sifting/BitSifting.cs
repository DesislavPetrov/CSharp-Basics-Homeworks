using System;

class BitSifting
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine()); // enter the number
        int sievesNumber = int.Parse(Console.ReadLine()); // enter the number of the sieves

        for (int i = 0; i < sievesNumber; i++)
        {
            ulong sieve = ulong.Parse(Console.ReadLine()); // enter the sieve value
            number = number & (~sieve); // the new value of the number after the sieve
        }

        ulong bitsCount = 0; // count the bits
        while (number > 0)
        {
            bitsCount += number & 1;
            number = number >> 1;
        }

        Console.WriteLine(bitsCount);
    }
}


