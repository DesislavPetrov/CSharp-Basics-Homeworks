using System;

class JoroFootballPlayer
{
    static void Main()
    {
        string leap = Console.ReadLine(); // leap or not leap year
        int p = int.Parse(Console.ReadLine()); // number of holidays
        int h = int.Parse(Console.ReadLine()); // number of weekends Joro spends in his hometown

        int plays = (p / 2 + ((52 - h) * 2 / 3) + h);

        if (leap == "t")
        {
            plays = plays + 3;
        }

        Console.WriteLine(plays);
    }
}

