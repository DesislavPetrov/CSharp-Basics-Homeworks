using System;
using System.Numerics;


class CatalanNumbers
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        BigInteger catalan = 0;

        BigInteger upperBinomial = 1;
        BigInteger bottomFirstBinomial = 1;
        BigInteger bottomSecondBinomial = 1;

        for (int i = 1; i <= 2 * num; i++)
        {
            upperBinomial *= i;
        }

        for (int i = 1; i <= num + 1; i++)
        {
            bottomFirstBinomial *= i;
        }

        for (int i = 1; i <= num; i++)
        {
            bottomSecondBinomial *= i;
        }

        catalan = (long)(upperBinomial / (bottomFirstBinomial * bottomSecondBinomial));

        Console.WriteLine(catalan);
    }
}
