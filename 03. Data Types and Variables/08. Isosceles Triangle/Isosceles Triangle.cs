
using System;
using System.Text;
class IsoscelesTriangle
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; // we must add System.Text
        char symbol = '\u00a9';
        string blank = " ";

        int rows = 4;
        int cols = 7;

        int upperValue = cols / 2;
        int bottomValue = cols / 2;

        for (int i = 0; i < (rows - 1); i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == 0 && j == cols / 2)
                {
                    Console.Write(symbol);
                }
                else if (i > 0 && j == upperValue)
                {
                    Console.Write(symbol);
                }
                else if (i > 0 && j == bottomValue)
                {
                    Console.Write(symbol);
                }
                else
                {
                    Console.Write(blank);
                }
            }

            Console.WriteLine();

            upperValue--;
            bottomValue++;
        }

        for (int k = 1; k <= cols; k++)
        {
            if (k % 2 != 0)
            {
                Console.Write(symbol);
            }
            else
            {
                Console.Write(blank);
            }
        }

        Console.WriteLine();
    }
}
