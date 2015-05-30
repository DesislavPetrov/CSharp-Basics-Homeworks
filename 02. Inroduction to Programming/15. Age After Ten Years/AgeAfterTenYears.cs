using System;
using System.Globalization;

class AgeAfterTenYears
{
    static void Main()
    {
        DateTime bday = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // we'll use CultureInfo("en-US")
        DateTime today = DateTime.Now;

        int age = today.Year - bday.Year + 10;
        if ((today.Month <= bday.Month) && (today.Day < bday.Day))
        {
            age--;
        }
        Console.WriteLine(age);
    }
}

