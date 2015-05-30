
using System;


class Program
{
    public static void Main(string[] args)
    {
        // We must use nested if statements

        float num1 = float.Parse(Console.ReadLine());
        float num2 = float.Parse(Console.ReadLine());
        float num3 = float.Parse(Console.ReadLine());

        if (num1 <= num2)
        {
            if (num2 <= num3)
            {
                Console.WriteLine("{0} {1} {2}", num3, num2, num1);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", num2, num3, num1);
            }
        }
        else if (num2 <= num3)
        {
            if (num3 <= num1)
            {
                Console.WriteLine("{0} {1} {2}", num1, num3, num2);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", num3, num1, num2);
            }
        }
        else if (num3 <= num1)
        {
            if (num1 <= num2)
            {
                Console.WriteLine("{0} {1} {2}", num2, num1, num3);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", num1, num2, num3);
            }
        }
    }
}
