// Abraham García
// Are two numbers even?
// v2: ternary operator

using System;

class BothEven
{
    static void Main()
    {
        int n1, n2, even;

        Console.Write("Enter a number: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter another: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Are both even? ");

        /*
        if  ((n1 % 2 == 0) && (n2 % 2 == 0))
            even = 1;
        else
            even = 0;
        */

        even = ((n1 % 2 == 0) && (n2 % 2 == 0)) ? 1 : 0;
        
        if  (even == 1)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}
