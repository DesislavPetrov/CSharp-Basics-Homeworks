
using System;


class OddAndEvenProduct
{
    public static void Main(string[] args)
    {
        string inputLine = Console.ReadLine();

        string[] numbers = inputLine.Split(' ');

        int evenProduct = 1;
        int oddProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct = evenProduct * (int.Parse(numbers[i]));
            }
            else
            {
                oddProduct = oddProduct * (int.Parse(numbers[i]));
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes, product = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no, even_product = {0}", evenProduct);
            Console.WriteLine("no, odd_product = {0}", oddProduct);
        }
    }
}
