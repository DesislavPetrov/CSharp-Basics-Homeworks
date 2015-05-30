
using System;


class Arrow
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int allRowPos = number + (number - 1);

        int tempLeft = number / 2;
        int tempRight = allRowPos - (number / 2) - 1;

        string numberSign = "#";
        string dotSign = ".";

        // We draw the first row
        for (int i = 0; i < 1; i++)
        {
            for (int j = 0; j < allRowPos; j++)
            {
                if (j >= tempLeft && j <= tempRight)
                {
                    Console.Write(numberSign);
                }
                else
                {
                    Console.Write(dotSign);
                }
            }
        }

        Console.WriteLine(); // New row

        // We draw the rows between the first one and the middle one
        for (int i = 1; i < allRowPos / 2; i++)
        {
            for (int j = 0; j < allRowPos; j++)
            {
                if (j == tempLeft || j == tempRight)
                {
                    Console.Write(numberSign);
                }
                else
                {
                    Console.Write(dotSign);
                }
            }
            Console.WriteLine();
        }

        // We draw the middle row
        for (int i = allRowPos / 2; i < allRowPos / 2 + 1; i++)
        {
            for (int j = 0; j < allRowPos; j++)
            {
                if (j <= tempLeft || j >= tempRight)
                {
                    Console.Write(numberSign);
                }
                else
                {
                    Console.Write(dotSign);
                }
            }
        }

        tempLeft = 1;
        tempRight = allRowPos - 2;

        Console.WriteLine(); // New row

        // We draw the rows between the middle one and the last one
        for (int i = allRowPos / 2 + 1; i < allRowPos; i++)
        {
            for (int j = 0; j < allRowPos; j++)
            {
                if (j == tempLeft || j == tempRight)
                {
                    Console.Write(numberSign);
                }
                else
                {
                    Console.Write(dotSign);
                }
            }
            tempLeft++;
            tempRight--;
            Console.WriteLine();
        }
    }
}
