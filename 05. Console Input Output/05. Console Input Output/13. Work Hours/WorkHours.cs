using System;

class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine()); // enter the required work hours to finish the project
        int d = int.Parse(Console.ReadLine()); // enter the days available to finish the project
        int p = int.Parse(Console.ReadLine()); // the productivity in percent

        decimal bikingDays = (decimal)d / 10;

        decimal workHours = (decimal)(((d - bikingDays) * 12) * p / 100); // normal work day has 12 hours


        int difference = (int)workHours - h;

        if (workHours < h)
        {
            Console.WriteLine("No");
            Console.WriteLine(difference);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine(difference);
        }
    }
}
