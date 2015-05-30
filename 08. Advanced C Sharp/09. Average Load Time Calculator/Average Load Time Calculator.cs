using System;
using System.Collections.Generic;
using System.Linq;


class AverageLoadTimeCalculator
{
    static void Main(string[] args)
    {
        string inputLine = Console.ReadLine();
        Dictionary<string, double> timeSum = new Dictionary<string, double>(); // we must add System.Collections.Generic
        Dictionary<string, int> loadsCount = new Dictionary<string, int>(); // we must add System.Collections.Generic

        while (inputLine != string.Empty)
        {
            string[] list = inputLine.Split(' ');
            string webLink = list[2];
            double timeLength = double.Parse(list[3]);
            if (!timeSum.Keys.Contains(webLink)) // we must add System.Linq
            {
                timeSum[webLink] = timeLength;
                loadsCount[webLink] = 1;
            }
            else
            {
                timeSum[webLink] = timeSum[webLink] + timeLength;
                loadsCount[webLink]++;
            }
            inputLine = Console.ReadLine();
        }
        foreach (string webLink in timeSum.Keys)
        {
            Console.WriteLine(webLink + "-->" + (timeSum[webLink]) / loadsCount[webLink]);
        }
    }
}