// Sergio Gumpert
// Sign of a number (first approach)

using System;

class Sign
{
    static void Main ()
    {
        int n, sgn;
        
        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        // "if" sentence
        if ( n < 0 )
            sgn = -1;
        else
            sgn = 1;
        Console.WriteLine("Sign: {0}", sgn);
        
        // ternary operator
        sgn = n < 0 ? -1 : 1;
        Console.WriteLine("Sign: {0}", sgn);
    }
}
