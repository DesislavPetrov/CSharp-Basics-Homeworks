
using System;

class MoonGravitation
{
    public static void Main()
    {
        float earthWeight = float.Parse(Console.ReadLine()); // enter the weight of a man on the Earth
        float moonWeight = (earthWeight * 17 / 100); // here we check the weight on the Moon

        Console.WriteLine(moonWeight);
    }
}
