using System;


class NineDigitMagic
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int resultsCount = 0; // the number of available numbers according to the statement

        for (int num1 = 111; num1 <= 777; num1++)
        {
            int num2 = num1 + diff;
            int num3 = num2 + diff;
            if (Digits(num1) && Digits(num2) && Digits(num3) &&
                (num3 <= 777) &&
                CalcSum(num1) + CalcSum(num2) + CalcSum(num3) == sum)
            {
                Console.WriteLine("{0}{1}{2}", num1, num2, num3);
                resultsCount++;
            }
        }

        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }



    private static int CalcSum(int num) // we calculate the sum of the number
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        return sum;
    }

    private static bool Digits(int num) // we check if each digit is between one and seven
    {
        string digits = num.ToString();
        foreach (var digit in digits)
        {
            if (digit < '1' || digit > '7')
            {
                return false;
            }
        }
        return true;
    }
}