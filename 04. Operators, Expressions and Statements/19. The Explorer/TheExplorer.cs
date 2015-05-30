using System;

class TheExplorer
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // enter the width and the height of the diamond

        string star = "*";
        string dash = "-";

        int tempBottom = n / 2;
        int tempUpper = n / 2;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 && j == n / 2)
                {
                    Console.Write(star);
                }
                else if ((i > 0) && (j == tempBottom))
                {
                    Console.Write(star);
                }
                else if ((i > 0) && (j == tempUpper))
                {
                    Console.Write(star);
                }
                else
                {
                    Console.Write(dash);
                }
            }

            if (i < n / 2)
            {
                tempBottom--;
                tempUpper++;
            }
            else
            {
                tempBottom++;
                tempUpper--;
            }

            Console.WriteLine();
        }
    }
}
