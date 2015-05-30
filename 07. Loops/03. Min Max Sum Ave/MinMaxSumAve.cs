using System;


class MinMaxSumAve
{
    static void Main()
    {
        int numberCount = 3; //int.Parse(Console.ReadLine()); // enter the number of numbers

        int sum = 0;

        int min = 0;
        int max = 0;

        //float ave = 0;

        for (int i = 1; i <= numberCount; i++)
        {
            int number = int.Parse(Console.ReadLine());
           

            sum = sum + number;
            //ave = (float)(sum / i);
            if (number > max)
            {
                max = number;
            }
            

            if (number < min)
            {
                min = number;
            }

            
        }

        Console.WriteLine("{0}", sum);
        // Console.WriteLine("{0}", ave);
        Console.WriteLine("{0}", min);
        Console.WriteLine("{0}", max);
    }
}

