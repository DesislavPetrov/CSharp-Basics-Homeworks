using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string asterisk = "*";
        string dot = ".";

        int tempLeft = n / 2;
        int tempRight = n / 2;

        for (int i = 0; i <= n / 2; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == tempLeft || j == tempRight)
                {
                    Console.Write(asterisk);
                }
                else if (i == n / 2)
                {
                    Console.Write(asterisk);
                }
                else
                {
                    Console.Write(dot);
                }
            }
            tempLeft--;
            tempRight++;
            Console.WriteLine();
        }


        tempLeft = n / 4; // it's the distance between the roof's end point and the walls of the building
        tempRight = n - 1 - n / 4;

        for (int i = n / 2 + 1; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == tempLeft || j == tempRight)
                {
                    Console.Write(asterisk);
                }
                else if (i == n - 1 && j > tempLeft && j < tempRight)
                {
                    Console.Write(asterisk);
                }
                else
                {
                    Console.Write(dot);
                }
            }
            Console.WriteLine();
        }
    }
}
