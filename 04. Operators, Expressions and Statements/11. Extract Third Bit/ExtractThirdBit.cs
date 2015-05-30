using System;



    class ExtractThirdBit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); // enter the number

            int mask = number >> 3;
            int bitValue = mask & 1;

            Console.WriteLine("{0}",bitValue);
        }
    }

