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

        // First row
        for(int column = 0; column < side; column++)
            Console.Write(number);
        Console.WriteLine();
        
        // Middle rows
        for (int row = 0; row < side-2; row++)
        {
            Console.Write(number);
            for (int space = 0; space < side - 2; space++)
                Console.Write(" ");
            Console.Write(number);
            Console.WriteLine();
        }
        
        // Last row
        for(int column = 0; column < side; column++)
            Console.Write(number);
        Console.WriteLine();
    }
}
