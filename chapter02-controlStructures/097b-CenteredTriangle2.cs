// Diego Aníbal Lezcano Reissner

using System;

class CenteredTriangle
{
    static void Main()
    {
        Console.Write("Enter triangle width: ");
        int width = Convert.ToInt32(Console.ReadLine());

        int spaces = width % 2 == 0? width / 2 - 1 : width / 2;
        int hashes = width % 2 == 0? 2 : 1;

        while(hashes <= width)
        {
            for (int spc = 0; spc < spaces; spc++)
            {
                Console.Write(" ");
            }
            for (int hash = 0; hash < hashes; hash++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
            hashes = hashes + 2;
            spaces--;
        }
    }
}
