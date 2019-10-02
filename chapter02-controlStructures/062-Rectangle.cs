// Araceli Yáñez Muñoz
// Rectangle

using System;

class Rectangle
{
    static void Main()
    {
        Console.Write("Height? ");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Width? ");
        int width = Convert.ToInt32(Console.ReadLine());
        
        for ( int row = 0; row < height ; row++)
        {
            for ( int column = 0 ; column < width ; column++)
                Console.Write("#");
            Console.WriteLine();
        }
        
    }
}
