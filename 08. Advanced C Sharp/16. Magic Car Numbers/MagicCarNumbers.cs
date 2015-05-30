using System;


class Program
{
    static int count = 0;

    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());

        char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };

        for (int x = 0; x < letters.Length; x++)
        {
            for (int y = 0; y < letters.Length; y++)
            {
                for (int a = 0; a <= 9; a++)
                {
                    CheckMagicWeight("CA" + a + a + a + a + letters[x] + letters[y], magicWeight);
                    for (int b = 0; b <= 9; b++)
                    {
                        if (a != b)
                        {
                            CheckMagicWeight("CA" + a + b + b + b + letters[x] + letters[y], magicWeight);
                            CheckMagicWeight("CA" + a + a + a + b + letters[x] + letters[y], magicWeight);
                            CheckMagicWeight("CA" + a + a + b + b + letters[x] + letters[y], magicWeight);
                            CheckMagicWeight("CA" + a + b + a + b + letters[x] + letters[y], magicWeight);
                            CheckMagicWeight("CA" + a + b + b + a + letters[x] + letters[y], magicWeight);
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }

    static void CheckMagicWeight(string carNumbers, int magicWeight)
    {
        int weight = 0;

        foreach (var letter in carNumbers)
        {
            if (letter >= '0' && letter <= '9')
            {
                weight += (letter - '0');
            }
            else
            {
                weight += 10 * (letter - 'A' + 1);
            }
        }

        if (weight == magicWeight)
        {
            count++;
        }
    }
}