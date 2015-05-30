using System;
using System.Linq; // we add this, so we can use the array Max method


class SortingNumbers
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            numbers[i] = num;
        }

        Console.WriteLine(numbers.Max());


        Console.ReadKey(true);
    }
}
