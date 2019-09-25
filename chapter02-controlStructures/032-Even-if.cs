// Are two numbers even?
// v1: if

using System;

public class BothEven
{
    public static void Main()
    {
        int n1, n2, even;

        Console.Write("Enter a number: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter another: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        if  ((n1 % 2 == 0) && (n2 % 2 == 0))
            even = 1;
        else
            even = 0;
        
        Console.Write("Are both even? ");
        if  (even == 1)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}
