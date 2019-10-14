// Ruth Martínez Iborra
// Drawing a (rotated) function

using System;

class Function
{
    static void Main()
    {
        for (int x = 1; x <= 10; x ++)
        {
            int y = (x-5)*(x-5);
            for (int i = 1; i <= y; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
        }
    }
}
