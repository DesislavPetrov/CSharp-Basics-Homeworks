using System;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = { 'k', 'n', 'p', 's' };

        int resultsCount = 0;
        
        for (int first = 0; first < letters.Length; first++)
        {
            for (int second = 0; second < letters.Length; second++)
            {
                for (int third = 0; third < letters.Length; third++)
                {
                    for (int fourth = 0; fourth < letters.Length; fourth++)
                    {
                        string leftPart = "" + letters[first] + letters[second] + letters[third] + letters[fourth];
                        int weightLeft = CalcWeight(leftPart);
                        for (int fifth = 0; fifth < letters.Length; fifth++)
                        {
                            for (int sixth = 0; sixth < letters.Length; sixth++)
                            {
                                for (int seventh = 0; seventh < letters.Length; seventh++)
                                {
                                    for (int eighth = 0; eighth < letters.Length; eighth++)
                                    {
                                        string rightPart = "" + letters [fifth] + letters[sixth] + letters[seventh] + letters[eighth];
                                        int weightRight = CalcWeight(rightPart);
                                        if (Math.Abs(weightLeft - weightRight) == diff)
                                        {
                                            Console.WriteLine(leftPart + rightPart);
                                            resultsCount++;
                                        }
                                    }                
                                }
                            }
                        }
                    }
                }
            }
        } 
        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }
    private static int CalcWeight (string str)
    {
        int weight = 0;
        foreach (var ch in str)
        {
            switch (ch)
            {
                case 'k': weight+=1;
                break;
                case 's': weight+=3;
                break;
                case 'n': weight+=4;
                break;
                case 'p': weight+=5;
                break;
            }
        }
        return weight;
    }
} 
