using System;
using System.Globalization;  // we must add this, so we can use CultureInfo.InvariantCulture

class BeerTime
{
    static void Main()
    {
        DateTime dateTime;

        string beerString = Console.ReadLine();

        bool isParsed = DateTime.TryParse(beerString, out dateTime);
        if (isParsed)
        {
            DateTime beerTime = DateTime.Parse(beerString);

            // We must use CultureInfo.InvariantCulture so we can use the designator "tt"
            string sign = beerTime.ToString("tt", CultureInfo.InvariantCulture);
            

            if (sign == "PM")
            {
                if ((beerTime.Hour - 12) >= 1 && (beerTime.Hour - 12) < 12)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else // if sign == "AM"
            {
                if (beerTime.Hour >= 0 && beerTime.Hour < 3)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}
