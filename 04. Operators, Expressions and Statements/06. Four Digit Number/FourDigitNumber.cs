
using System;

class FourDigitNumber
{
    public static void Main()
    {
        string numberString = Console.ReadLine();

        int number = int.Parse(numberString); // enter the number in format abcd

        int fourthDigit = (number % 10); // digit d
        int thirdDigit = ((number / 10) % 10); // digit c
        int secondDigit = ((number / 100) % 10); // digit b
        int firstDigit = (number / 1000); // digit a

        int fourDigits = numberString.Length; // the length of the number

        if ((fourDigits == 4) && (firstDigit != 0)) // check if the number have four digits and start with digit different from zero 
        {
            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit; // calculate the sum

            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit); // dcba
            Console.WriteLine("{0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit); // dabc
            Console.WriteLine("{0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit); // acbd
        }
        else
        {
            Console.WriteLine("Your number must have 4 digits and can't start with zero");
        }
    }
}
