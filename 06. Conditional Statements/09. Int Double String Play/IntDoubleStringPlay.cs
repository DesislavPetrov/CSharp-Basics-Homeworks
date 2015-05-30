
using System;


class IntDOubleStringPlay
{
    public static void Main()
    {
        Console.WriteLine("Please, choose a type: \n" +
                            "1 --> int \n" +
                            "2 --> double \n" +
                            "3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.WriteLine("Please enter an integer:");
                int choice1 = (int.Parse(Console.ReadLine())) + 1;
                Console.WriteLine(choice1);
                break;
            case 2: Console.WriteLine("Please enter a double:");
                double choice2 = (double.Parse(Console.ReadLine())) + 1;
                Console.WriteLine(choice2);
                break;
            case 3: Console.WriteLine("Please enter a string:");
                string choice3 = Console.ReadLine();
                Console.WriteLine(choice3 + "*");
                break;
        }
    }
}
