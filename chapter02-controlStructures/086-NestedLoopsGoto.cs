//Pablo Conde
//goto bucles anidados

using System;

class GotoBuclesAnidados
{
     static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 20; j <= 30; j = j+2)
            {
                if (i == 3 && j > 25)
                {
                    Console.WriteLine("Tryng to break...");
                    goto outOfLoops;
                }
            
                Console.WriteLine("{0} - {1} ", i, j);
            }
        }
    outOfLoops:
        Console.WriteLine("We did it!");
    }                                                                 
}
