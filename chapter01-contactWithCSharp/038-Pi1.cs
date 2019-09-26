using System;

class Pi1
{
    static void Main()
    {
        Console.WriteLine("PI is approx. {0}", 22.0 / 7.0);
        
        int pi = 22/7;
        Console.WriteLine("With int: {0}", pi);
        
        int piInt =      22 * 1000 / 7 / 1000;
        int piDecimals = 22 * 1000 / 7 % 1000;
        Console.WriteLine("Or: {0}.{1}", piInt, piDecimals);
        
    }
}
