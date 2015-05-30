
using System;


class DecimalToBinary
{
    public static void Main(string[] args)
    {
        string inputLine = Console.ReadLine();
        long decimalNumber = long.Parse(inputLine);

        long tempDecimal = decimalNumber; // we create a temporary value that keep the value of decimalNumber

        long binaryNumber = 0; // it's the initial value of the binaryNumber
        int binaryCount = 0; // we create a counter for the number of the digits of the binary number

        while (decimalNumber > 0)
        {
            binaryNumber = decimalNumber % 2; // we find the value of the digits of the binary number
            decimalNumber /= 2;
            binaryCount++;
        }

        long[] binaryNumberArray = new long[binaryCount];
        for (int i = binaryCount - 1; i >= 0; i--)
        {
            binaryNumberArray[i] = tempDecimal % 2; // we fill the array with tha values of the binary number
            tempDecimal = tempDecimal /= 2;
        }

        for (int i = 0; i < binaryCount; i++)
        {
            Console.Write(binaryNumberArray[i]); // we print the binary number
        }
    }
}
