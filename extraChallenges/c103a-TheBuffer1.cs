// Pablo Conde
// The buffer: amount of usable urinals in mens bathroom

using System;

class Urinario
{
     static void Main()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < cases; i++)
        {
            int urinals = Convert.ToInt32(Console.ReadLine());
        
            if (urinals % 2 == 0)
                Console.WriteLine(urinals/2);
            else
                Console.WriteLine(urinals/2 + 1);
        }        
    }
}
