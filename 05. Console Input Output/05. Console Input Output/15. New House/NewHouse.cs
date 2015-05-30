using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string asterisk = "*";
        string dash = "-";
        string pipe = "|";

        int rows = (n + (n + 1) / 2);
        int cols = n;

        int tempLeft = n / 2;
        int tempRight = n / 2;

        for (int i = 0; i <= n / 2; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (j < tempLeft)
                {
                    Console.Write(dash);
                }
                else if (j > tempRight)
                {
                    Console.Write(dash);
                }
                else
                {
                    Console.Write(asterisk);
                }
            }
            tempLeft--;
            tempRight++;
            Console.WriteLine();
        }

        for (int i = n / 2 + 1; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i > n / 2 && j == 0)
                {
                    Console.Write(pipe);
                }
                else if (i > n / 2 && j == cols - 1)
                {
                    Console.Write(pipe);
                }
                else
                {
                    Console.Write(asterisk);
                }
            }
            Console.WriteLine();
        }
    }
}

