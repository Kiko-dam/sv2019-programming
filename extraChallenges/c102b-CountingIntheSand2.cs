// Sergio Gumpert
// Counting in the sand: display as many "1" as told

using System;
class x
{
    static void Main()
    {
        
        int i = Convert.ToInt32(Console.ReadLine());
        while ( i != 0)
        {
            for(int x = 0 ; x < i ; x++)
                Console.Write("1");
            Console.WriteLine();
            
            i = Convert.ToInt32(Console.ReadLine());
        }
    }
}
