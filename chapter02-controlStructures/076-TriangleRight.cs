// Triangle of asterisks, right aligned

using System;

class TriangleRight
{
    static void Main()
    {
        int side;
        int spaces, asterisks;

        Console.Write("Enter the side of the triangle: ");
        side = Convert.ToInt32(Console.ReadLine());
        spaces = side - 1;
        asterisks = 1;

        // Several rows
        for (int row = 1; row <= side; row++)
        {
            // Several columns in each row
            for (int column = 1; column <= spaces; column++)
            {
                Console.Write(" ");
            }
            for (int column = 1; column <= asterisks; column++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            
            spaces --;
            asterisks ++;
        }
    }
}
