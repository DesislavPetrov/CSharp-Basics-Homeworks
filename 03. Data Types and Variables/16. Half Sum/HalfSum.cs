using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sumOne = 0;
        for (int count = 0; count < n; count++)
        {
            int element1 = int.Parse(Console.ReadLine());
            sumOne = sumOne + element1;
        }

        int sumTwo = 0;
        for (int count = 0; count < n; count++)
        {
            int element2 = int.Parse(Console.ReadLine());
            sumTwo = sumTwo + element2;
        }

        if (sumOne == sumTwo)
        {
            Console.WriteLine("Yes, sum={0}", sumOne);
        }
        else
        {
            int diff = Math.Abs(sumOne - sumTwo);
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}
