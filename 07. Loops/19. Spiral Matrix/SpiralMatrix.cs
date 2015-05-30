using System;


class SpiralMatrix
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int[,] matrix = new int[num, num];

        int row = 0;
        int col = 0;

        // create a variable that show the direction - the initial value is "right"
        string direction = "right";

        int maxRotations = num * num;

        for (int i = 1; i <= maxRotations; i++)
        {
            // first we must check if the cell is into the matrix with for if-s
            if (direction == "right" && (col > num - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > num - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;

            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "right";
                row++;
                col++;
            }

            // then we must write the value
            matrix[row, col] = i; 

            // after that we change the cell
            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }


        // display matrix
        for (int r = 0; r < num; r++)
        {
            for (int k = 0; k < num; k++)
            {
                Console.Write("{0,4}", matrix[r, k]);
            }
            Console.WriteLine();
        }
    }
}