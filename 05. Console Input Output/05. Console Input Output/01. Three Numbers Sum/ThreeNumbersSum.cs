using System;


class ThreeNumbersSum
{
    static void Main()
    {
        Console.WriteLine("Read the first number");
        float firstNumber = float.Parse(Console.ReadLine());

        Console.WriteLine("Read the second number");
        float secondNumber = float.Parse(Console.ReadLine());

        Console.WriteLine("Read the third number");
        float thirdNumber = float.Parse(Console.ReadLine());

        float sum = (float) firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of the three numbers is {0}", sum);
    }
}

