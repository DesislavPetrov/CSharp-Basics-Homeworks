using System;


    class NumbersOneToN
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <= number)
            {
                Console.Write("{0} ", counter);
                counter++;
            }
        }
    }

