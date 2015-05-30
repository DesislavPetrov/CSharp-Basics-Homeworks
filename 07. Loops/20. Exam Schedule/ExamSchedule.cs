
using System;
using System.Globalization;


class ExamSchedule
{
    public static void Main()
    {
        int startHour = int.Parse(Console.ReadLine());
        int startMinute = int.Parse(Console.ReadLine());
        string startDayPart = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());

        if (startDayPart == "PM")
        {
            startHour = startHour + 12;
            if (startHour == 24)
            {
                startHour = 0;
            }
        }

        DateTime startTime = new DateTime(2015, 02, 09, startHour, startMinute, 0);
        DateTime endTime = startTime.AddHours(durationHours).AddMinutes(durationMinutes);

        Console.WriteLine(endTime.ToString("hh:mm:tt", CultureInfo.InvariantCulture));
    }
}
