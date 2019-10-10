// Square of asterisks

using System;

class Square
{
    static void Main()
    {
        int number, side;
        
        Console.Write("Enter the number for the square: ");
        number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the side of the square: ");
        side = Convert.ToInt32(Console.ReadLine());

        // Several rows
        for (int row = 1; row <= side; row++)
        {
            // Several columns in each row
            for (int column = 1; column <= side; column++)
            {
                if ((row == 1) || (row == side)
                        || (column == 1) || (column == side))
                    Console.Write(number);
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
