
using System;

class ExchangeVariableValues
{
    public static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("The old value of integer a is {0}", a);
        Console.WriteLine("The old value of integer b is {0}", b);

        int oldA = a; // here we use temp variable
        a = b;
        b = oldA;

        Console.WriteLine("The new value of integer a is {0}", a);
        Console.WriteLine("The new value of integer b is {0}", b);
    }
}
