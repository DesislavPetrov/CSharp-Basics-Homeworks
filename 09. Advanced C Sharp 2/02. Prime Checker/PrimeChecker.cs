using System;


class PrimeChecker
{
    static void Main(string[] args)
    {
        long num = long.Parse(Console.ReadLine());
        IsPrime(num);
    }
    static void IsPrime(long n)
    {
        bool isPrime = true;
        long squaredNum = (long)Math.Sqrt(n);

        if (n < 2)
        {
            isPrime = false;
        }
        else
        {
            for (long i = 2; i <= squaredNum; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
        }
        Console.WriteLine(isPrime);
    }
}
