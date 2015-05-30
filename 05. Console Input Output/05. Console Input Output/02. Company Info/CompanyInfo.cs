using System;

class CompanyInfo
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyNameInput = Console.ReadLine();
        string companyName = "Company Name";

        Console.Write("Company adress: ");
        string companyAddressInput = Console.ReadLine();
        string companyAddress = "Company address";

        Console.Write("Phone number: ");
        string phoneNumberInput = Console.ReadLine();
        string phoneNumber = "Phone number";

        string faxNumber = "Fax number";

        Console.Write("Website: ");
        string websiteInput = Console.ReadLine();
        string website = "Website: ";

        Console.Write("Manager first name: ");
        string firstNameInput = Console.ReadLine();
        string firstName = "Manager first name";

        Console.Write("Manager last name: ");
        string lastNameInput = Console.ReadLine();
        string lastName = "Manager last name";

        Console.Write("Manager age: ");
        string ageInput = Console.ReadLine();
        string age = "Manager age";

        Console.Write("Manager phone: ");
        string managerPhoneInput = Console.ReadLine();
        string managerPhone = "Manager phone";

        Console.WriteLine();

        Console.WriteLine("{0,-20} | {1}", companyName, companyNameInput);
        Console.WriteLine("{0,-20} | {1}", companyAddress, companyAddressInput);
        Console.WriteLine("{0,-20} | {1}", phoneNumber, phoneNumberInput);
        Console.WriteLine("{0,-20} |    ", faxNumber);
        Console.WriteLine("{0,-20} | {1}", website, websiteInput);
        Console.WriteLine("{0,-20} | {1}", firstName, firstNameInput);
        Console.WriteLine("{0,-20} | {1}", lastName, lastNameInput);
        Console.WriteLine("{0,-20} | {1}", age, ageInput);
        Console.WriteLine("{0,-20} | {1}", managerPhone, managerPhoneInput);
    }
}
