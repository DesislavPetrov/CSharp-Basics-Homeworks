using System;



class OddEvenElements
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InvariantCulture;
        
        string inputLine = Console.ReadLine();
        string[] numbers = inputLine.Split(' ');

        decimal oddSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;

        decimal evenSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;

        if (inputLine == "")
        {
               Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else
        { 
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddSum = oddSum + (decimal.Parse(numbers[i]));
                    if (decimal.Parse(numbers[i]) < oddMin)
                    {
                        oddMin = decimal.Parse(numbers[i]);
                    }
                    if (decimal.Parse(numbers[i]) > oddMax)
                    {
                        oddMax = decimal.Parse(numbers[i]);
                    }
                }
                else
                {
                    evenSum = evenSum + (decimal.Parse(numbers[i]));
                    if (decimal.Parse(numbers[i]) < evenMin)
                    {
                        evenMin = decimal.Parse(numbers[i]);
                    }
                    if (decimal.Parse(numbers[i]) > evenMax)
                    {
                        evenMax = decimal.Parse(numbers[i]);
                    }
                }
            }
            if (numbers.Length == 1)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
                                    (double)oddSum, (double)oddMin, (double)oddMax);
            }
            else
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5} ",
                                    (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
            }
        }
    }
}

