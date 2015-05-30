using System;


class NumbersNotDivisible
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= number)
        {
            if ((counter % 3 != 0) && (counter % 7 != 0))
            {
                Console.Write("{0} ", counter);
            }
            
            counter++;
        }
    }
}

