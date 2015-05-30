using System;
using System.Collections.Generic;


class Program
{
    public static void Main()
    {
        int cablesNum = int.Parse(Console.ReadLine());

        int lengthSum = 0; // this variable will store the length of the cable
        int count = 0; // this variable will store the number of used cables
        int remainingLength = 0;

        for (int i = 0; i < cablesNum; i++)
        {
            int cableLength = int.Parse(Console.ReadLine());
            string dimension = Console.ReadLine();

            if (dimension == "meters")
            {
                cableLength = cableLength * 100;
            }
            if (cableLength >= 20)
            {
                lengthSum += cableLength;
                count++;
            }

        }

        // it is needed 3 cm for joining every two pieces of cable

        lengthSum = lengthSum - ((count - 1) * 3);

        // the length of the cable is 5 m and two RJ45 connectors each with a length of 2 cm

        count = lengthSum / 504; // here we already use the "count" variable for the count of the new cables configuration
        remainingLength = lengthSum % 504; // here we calculate the length of the remaining unused cable

        Console.WriteLine(count);
        Console.WriteLine(remainingLength);
    }
}

