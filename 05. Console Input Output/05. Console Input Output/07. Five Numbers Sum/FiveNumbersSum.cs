using System;

class FiveNumbersSum
{
    static void Main(string[] args)
    {
        string numbers = Console.ReadLine();

        double a = Convert.ToDouble(numbers.Split(' ')[0]);
        double b = Convert.ToDouble(numbers.Split(' ')[1]);
        double c = Convert.ToDouble(numbers.Split(' ')[2]);
        double d = Convert.ToDouble(numbers.Split(' ')[3]);
        double e = Convert.ToDouble(numbers.Split(' ')[4]);

        float sum = (float)(a + b + c + d + e);
        Console.WriteLine("{0}", sum);
    }
}

