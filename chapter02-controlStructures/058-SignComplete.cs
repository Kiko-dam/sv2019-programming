// DAVID BERENGUER ANTON
// Sign of a number

using System;

class Sign
{
    static void Main()
    {
        int num, sgn, sgn2;

        Console.WriteLine("Enter a number: ");
        num=Convert.ToInt32(Console.ReadLine() );

        // "if" statement
        if (num < 0)
            sgn = -1;
        else if (num > 0)
            sgn = 1;
        else
            sgn = 0;

        Console.WriteLine("The sign of {0} is {1}",num,sgn);

        // two ternary operators
        sgn2 = num > 0 ? 1 : 0;
        sgn = num < 0 ? -1 : sgn2;
        Console.WriteLine("The sign of {0} is {1}",num,sgn);

        // nested ternary operators
        sgn = num < 0 ? -1 :  (num > 0 ? 1 : 0);
        Console.WriteLine("The sign of {0} is {1}",num,sgn);
    }
}
