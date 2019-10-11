// Cristina Francés
// The buffer: amount of usable urinals in mens bathroom

using System;

class Buffer
{
    static void Main()
    {   
        int cases = Convert.ToInt32(Console.ReadLine());
        
        int numUri, men;
        
        for (int i = 0; i < cases; i++)
        {
            numUri = Convert.ToInt32(Console.ReadLine());
            men = (numUri+1) / 2;
            Console.WriteLine(men);
        }
        
        
    }
}
