// Common dividers of two numbers

using System;

class CommonDividers
{
    static void Main()
    {
        int n1, n2;

        Console.Write("Enter a number: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Their common dividers are... ");
        for(int i = 2; i <= n1; i++)
            if( (n1 % i == 0) && (n2 % i == 0) )
                Console.Write("{0} ", i);
    }
}
