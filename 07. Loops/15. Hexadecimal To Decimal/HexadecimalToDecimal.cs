using System;


class HexadecimalToDecimal
{
    public static void Main()
    {
        string input = Console.ReadLine();

        char[] el = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E','F'};
        double result = 0;

        for (int i = 0; i < input.Length; i++)
        {
            double digit = Array.IndexOf(el, input[i]);
            result += digit * (Math.Pow(16, input.Length - i - 1));
        }

        Console.WriteLine(result);
    }
} 

