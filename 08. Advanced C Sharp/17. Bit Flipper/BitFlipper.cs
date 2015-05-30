using System;


class Program
{
    public static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());

        int endBit = 62; // the end bit must be equal to 64-2

        while (endBit > 0)
        {
            endBit--;
            ulong lastThreeBits = (num >> endBit) & 7;
            if (lastThreeBits == 0 || lastThreeBits == 7)
            {
                num = num ^ ((ulong)7 << endBit);
                endBit -= 2;
            }
        }
        Console.WriteLine(num);
    }
}