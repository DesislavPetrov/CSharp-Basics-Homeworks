
using System;
using System.Collections.Generic;
using System.Text;

class PrintASCIITable
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("{0} = {1}", i, (char)i);
        }
        Console.WriteLine("Hello World!");
    }
}
