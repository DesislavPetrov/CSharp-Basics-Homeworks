using System;

    class NumbersInInterval
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            int diff = numberTwo - numberOne;

            int count = (Math.Abs(diff / 5));
            if (numberOne % 5 == 0 || numberTwo % 5 == 0)
            {
                count++;
            }

            Console.WriteLine("{0}", count);
        }
    }
