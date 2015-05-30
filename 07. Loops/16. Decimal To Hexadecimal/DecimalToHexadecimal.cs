using System;


class DecimalToHexadecimal
{
    public static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        long divisor = 0;
        long remainder = 0;
        string hexadecimalNum = "";
        char[] el = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };


        divisor = input / 16;
        remainder = input % 16;


        while (divisor >= 0)
        {
            hexadecimalNum += el[remainder];
            if (divisor == 0)
            {
                break;
            }
            remainder = divisor % 16;
            divisor = divisor / 16;
        }

        char[] charArray = hexadecimalNum.ToCharArray();
        Array.Reverse(charArray);
        string reversedHexNum = "";
        for (int i = 0; i < charArray.Length; i++)
			{
                reversedHexNum += charArray[i];
			}
        
        Console.WriteLine(reversedHexNum);
    }
}