using System;

class PrintCardsDeck
{
    static void Main()
    {
        for (int row = 2; row <= 14; row++)
        {
            for (int col = 5; col < 7; col--)
            {
                if (row < 11)
                {
                    Console.Write("{0}{1} ", row, (char)col);
                }
                switch (row)
                {
                    case 11: Console.Write("J{0} ", (char)col);
                        break;
                    case 12: Console.Write("Q{0} ", (char)col);
                        break;
                    case 13: Console.Write("K{0} ", (char)col);
                        break;
                    case 14: Console.Write("A{0} ", (char)col);
                        break;
                }
                if (col == 3)
                {
                    col = 7;
                }
                if (col == 6)
                {
                    break;
                }
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}