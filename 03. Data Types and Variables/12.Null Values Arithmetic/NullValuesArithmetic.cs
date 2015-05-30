
using System;


class NullValuesArithmetic
{
    public static void Main()
    {
        int? valueInt = null;
        double? valueDouble = null;

        Console.WriteLine(valueInt);
        Console.WriteLine(valueDouble);

        int? valueInt2 = valueInt + 3;
        double? valueDouble2 = valueDouble + 3.5427854;

        Console.WriteLine(valueInt2);
        Console.WriteLine(valueDouble2);
    }
}
