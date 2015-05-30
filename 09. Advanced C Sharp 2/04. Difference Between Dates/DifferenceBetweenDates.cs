using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        string dateStringFirst = Console.ReadLine();
        string dateStringSecond = Console.ReadLine();
        string format = "d.MM.yyyy";
        DateTime firstDate = DateTime.ParseExact(dateStringFirst, format,
        CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(dateStringSecond, format,
        CultureInfo.InvariantCulture);
        int difference = DatesDifference(firstDate, secondDate);
        Console.WriteLine(difference);
    }
    private static int DatesDifference(DateTime firstDate, DateTime secondDate)
    {
        // Difference in days, hours, and minutes.
        TimeSpan ts = secondDate - firstDate;
        // Difference in days.
        int differenceInDays = ts.Days;
        return differenceInDays;
    }
}