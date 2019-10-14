using System;
// y = x2 - 2x + 1 
// -10 to +10

class Program
{
    static void Main()
    {
        for (int x = -10; x <= 10; x++)
        {
            int y = x*x - 2*x + 1;
            Console.WriteLine(y);
        }
    }
}
