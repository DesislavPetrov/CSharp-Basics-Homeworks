
using System;

class BankAccountData
{
    public static void Main()
    {

        string firstName = "Pesho";
        string middleName = "Georgiev";
        string lastName = "Ivanov";

        decimal balance = 12347.453M;

        string bankName = "National Bank";
        string iban = "1234bgrt";
        string cardOne = "7218937219371";
        string cardTwo = "7218937219372";
        string cardThree = "7218937219373";

        Console.WriteLine(firstName);
        Console.WriteLine(middleName);
        Console.WriteLine(lastName);

        Console.WriteLine(balance);

        Console.WriteLine(bankName);
        Console.WriteLine(iban);
        Console.WriteLine(cardOne);
        Console.WriteLine(cardTwo);
        Console.WriteLine(cardThree);
    }
}
