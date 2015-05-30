using System;

class MatrixNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= 20)
        {
            int numbers = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < n; j++)
                {
                    Console.Write(numbers);
                    numbers++;
                }

                numbers = numbers - 2;

            }
        }
        else
        {
            Console.WriteLine("You must enter valid integer number between 0 and 20");
        }
        Console.WriteLine();

    }
}
