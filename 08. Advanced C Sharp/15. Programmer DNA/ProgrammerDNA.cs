using System;


class ProgrammerDNA
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        string stringInput = Console.ReadLine();
        char charInput = char.Parse(stringInput);

        char point = '.';

        char currLetter = 'A'; // he we will keep the current character

        for (int row = 0; row < num; row++)
        {
            for (int col = 0; col < 7; col++)
            {
                if (row == 0 && col == 3)
                {
                    Console.Write(charInput);
                    currLetter = charInput;
                    currLetter++;
                }
                else
                {
                    if ((row % 7 == 0 || row % 7 == 6) && col == 3)
                    {
                        Console.Write(currLetter);
                        currLetter++;
                    }
                    else if ((row % 7 == 1 || row % 7 == 5) && (col >= 2 && col <= 4))
                    {
                        Console.Write(currLetter);
                        currLetter++;
                    }
                    else if ((row % 7 == 2 || row % 7 == 4) && (col >= 1 && col <= 5))
                    {
                        Console.Write(currLetter);
                        currLetter++;
                    }
                    else if (row % 7 == 3)
                    {
                        Console.Write(currLetter);
                        currLetter++;
                    }
                    else
                    {
                        Console.Write(point);
                    }
                }

                if (currLetter > 'G')
                {
                    currLetter = 'A';
                }
            }
            Console.WriteLine();
        }
    }
}