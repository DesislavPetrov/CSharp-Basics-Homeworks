using System;


class BiggestOfThree
{
    public static void Main()
    {
        float num1 = float.Parse(Console.ReadLine());
        float num2 = float.Parse(Console.ReadLine());
        float num3 = float.Parse(Console.ReadLine());

        float max = num1;

        if (num2 > num1 && num2 > num3)
        {
            max = num2;
        }
        else if (num3 > num1)
        {
            max = num3;
        }

        Console.WriteLine("The biggest number is {0}", max);
    }
}
