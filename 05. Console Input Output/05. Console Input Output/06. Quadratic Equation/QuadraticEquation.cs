using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter a number \"a\"");
        float a = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter a float number \"b\"");
        float b = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter a float number \"c\"");
        float c = float.Parse(Console.ReadLine());

        float determinant = (float)(b * b - 4 * a * c);

        if (determinant < 0) // check if there are any real roots
        {
            Console.WriteLine("This quadratic equation has no real roots");
        }
        else
        {
            float rootOne = (float)((-b + Math.Sqrt(determinant)) / (2 * a));
            float rootTwo = (float)((-b - Math.Sqrt(determinant)) / (2 * a));

            if (rootOne == rootTwo)
            {
                Console.WriteLine("X1 = X2 = {0}", rootOne);
            }
            else if (rootOne != rootTwo)
            {
                Console.WriteLine("X1 = {0}", rootOne);
                Console.WriteLine("X2 = {0}", rootTwo);
            }
        }
    }
}
