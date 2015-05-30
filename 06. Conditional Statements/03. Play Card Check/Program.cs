using System;
using System.Linq;

    class Program
{
    static void Main()
    {
        string sign = Console.ReadLine();


        switch (sign)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "K":
            case "A": Console.WriteLine("yes");
                break;
            default: Console.WriteLine("no");
                break;
        }
	}
}
   
