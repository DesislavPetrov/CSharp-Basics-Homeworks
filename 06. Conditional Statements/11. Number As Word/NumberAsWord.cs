using System;

class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int thirdNum = num % 10;
        int secondNum = (num / 10) % 10;
        int firstNum = (num / 100);

        string thirdString;
        string secondString;
        string firstString;

        string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] tens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] tenToNineteen = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        string result = "";

        if (num >= 0 && num <= 9)
        {
            thirdString = ones[num];
            result = "" + thirdString;
        }

        else if (num >= 10 && num <= 19)
        {
            thirdString = tenToNineteen[thirdNum];
            result = thirdString;
        }

        else if (num % 10 == 0 && num < 100)
        {
            secondString = tens[secondNum - 2];
            result = secondString;
        }
        else if (num > 20 && num < 100)
        {
            thirdString = ones[thirdNum];
            secondString = tens[secondNum - 2];
            result = secondString + " " + thirdString;
        }

        else if (num % 100 == 0)
        {
            firstString = ones[firstNum];
            result = firstString + " hundred";
        }

        else if (num > 100 && num <= 999)
        {
            if (secondNum >= 2)
            {
                firstString = ones[firstNum];
                secondString = tens[secondNum - 2];
                thirdString = ones[thirdNum];
                result = firstString + " hundred and " + secondString + " " + thirdString;
            }
            else if (secondNum == 0)
            {
                firstString = ones[firstNum];
                thirdString = ones[thirdNum];
                result = firstString + " hundred and " + thirdString;
            }
            else if (secondNum == 1) // secondNum == 1
            {
                firstString = ones[firstNum];
                thirdString = tenToNineteen[thirdNum];
                result = firstString + " hundred and " + thirdString;
            }
        }
        Console.WriteLine(char.ToUpper(result[0]) + result.Substring(1));
        Console.ReadKey(true);
    }
}