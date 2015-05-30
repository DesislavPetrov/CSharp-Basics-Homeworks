
using System;


class Volleyball
{
    public static void Main()
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine()); // number of holidays in the year
        int h = int.Parse(Console.ReadLine()); // number of weekends Vladi spends in his hometown

        int totalWeekends = 48;

        int normalWeekends = totalWeekends - h;

        float normalWeekendsPlays = (float) normalWeekends * 3 / 4;

        float holidaysPlays = (float) p * 2 / 3;

        float floatPlays = h + (normalWeekendsPlays) + (holidaysPlays);

        if (year == "leap") // we check if the year is leap or normal
        {
            floatPlays = floatPlays + (floatPlays * 15 / 100); // the result
        }

        int roundedPlays = (int)floatPlays; // we round down the result

        Console.WriteLine(roundedPlays);
    }
}
