using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number \"n\"");
        int n = int.Parse(Console.ReadLine());

        int first = 0;
        int second = 1;
        int sum = 1;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", first);

            first = second;
            second = sum;
            sum = first + second;

        }
    }
}
