// Square of asterisks

using System;

class Square
{
    static void Main()
    {
        int side;

        Console.Write("Enter the side of the square: ");
        side = Convert.ToInt32(Console.ReadLine());

        // Several rows
        for (int row = 1; row <= side; row++)
        {
            // Several columns in each row
            for (int column = 1; column <= side; column++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
