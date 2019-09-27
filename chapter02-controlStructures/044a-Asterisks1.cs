/*

Write a C# program in to show as many asterisks on the screen as 
told by the user, in the same row. For example, if the user enters 
7, the answer would be:

*******

*/

using System;

class Asterisks
{
    static void Main()
    {
        Console.Write("How many asterisks? ");
        int n = Convert.ToInt32( Console.ReadLine() );
        
        int i = 1;

        while (i <= n)
        {
            Console.Write("*");
            i = i + 1;
        }
        Console.WriteLine();
    }
}

