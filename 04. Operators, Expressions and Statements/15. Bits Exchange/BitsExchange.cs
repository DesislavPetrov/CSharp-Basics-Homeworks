using System;


    class BitsExchange
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine()); // enter the number

            for (int position = 3; position < 6; position++)
            {
                uint firstGroup = (number >> position) & 1;
                uint secondGroup = (number >> (position + 21)) & 1;

                if (firstGroup != secondGroup) // we check if the bit values from the two groups are different
                {
                    uint maskOne = (uint)(1 << (position + 21));
                    uint maskTwo = (uint)(1 << position);

                    number = number ^ maskOne;
                    number = number ^ maskTwo;
                }
            }
            Console.WriteLine(number);
        }
    }

