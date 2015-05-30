
using System;


class BinaryToDecimal
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();
        long decimalNumber = 0;

        for (int i = 0; i < inputLine.Length; i++)
        {
            long currNum = long.Parse(inputLine.Substring(i, 1));
            decimalNumber += (currNum * (long)Math.Pow(2, (inputLine.Length - 1) - i));
        }
                
        Console.WriteLine(decimalNumber);
    }
}
