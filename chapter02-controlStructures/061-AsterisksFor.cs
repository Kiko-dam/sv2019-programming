/*

Write a C# program in to show as many asterisks on the screen as 
told by the user, in the same row. For example, if the user enters 
7, the answer would be:

*******

(note: use the "for" statement)

*/

using System;

class AsterisksFor
{
    static void Main()
    {
        Console.Write("How many asterisks? ");
        int n = Convert.ToInt32( Console.ReadLine() );

        for (int i = 0; i < n; i++)
            Console.Write("*");
        Console.WriteLine();
    }
}

