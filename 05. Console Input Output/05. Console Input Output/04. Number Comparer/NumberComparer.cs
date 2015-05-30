using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter the first number");
        float firstNumber = float.Parse(Console.ReadLine());


        Console.WriteLine("Enter the second number");
        float secondNumber = float.Parse(Console.ReadLine());

        float greater = Math.Max(firstNumber, secondNumber);
        Console.WriteLine(greater);
    }
}

