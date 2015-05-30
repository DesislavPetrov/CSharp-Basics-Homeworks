
using System;

namespace Biggest_Five_Numbers_06
{
    class Program
    {
        public static void Main()
        {
            float number1 = float.Parse(Console.ReadLine());
            float number2 = float.Parse(Console.ReadLine());
            float number3 = float.Parse(Console.ReadLine());
            float number4 = float.Parse(Console.ReadLine());
            float number5 = float.Parse(Console.ReadLine());

            float max = number1; // we create a temporary variable to consist of the biggest number

            if (number2 > max)
            {

                max = number2;
            }
            if (number3 > max)
            {

                max = number3;
            }
            if (number4 > max)
            {

                max = number4;
            }
            if (number5 > max)
            {

                max = number5;
            }
            Console.WriteLine("The biggest number is {0}", max);
        }
    }
}