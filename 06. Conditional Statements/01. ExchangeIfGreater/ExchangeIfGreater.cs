using System;


class ExchangeIfGreater
{
    public static void Main(string[] args)
    {
            int first = int.Parse(Console.ReadLine()); // enter the first number
            int second = int.Parse(Console.ReadLine()); // enter the second numbe

            if (first > second)
            {
                int temp = first; // we create a temporary variable that consists of the first number
                first = second;
                second = temp;
            }

            Console.WriteLine("{0} {1}", first, second);
      }
}

