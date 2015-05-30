using System;



class BonusScore
{
    static void Main(string[] args)
    {
        int score = int.Parse(Console.ReadLine()); // enter the score
        int result = 0;

        if (score <= 3 && score >= 1) // we check for the statement
        {
            result = score * 10; // we calculate the result
            Console.WriteLine(result);
        }
        else if (score <= 6 && score >= 4)
        {
            result = score * 100;
            Console.WriteLine(result);
        }
        else if (score <= 9 && score >= 7)
        {
            result = score * 1000;
            Console.WriteLine(result);
        }
        else
        {
            result = score * 100;
            Console.WriteLine("invalid score");
        }
    }
        
}
