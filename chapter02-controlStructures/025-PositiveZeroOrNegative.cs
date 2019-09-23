// Saúl Cánovas Navarro

using System;

class PositiveZeroOrNegative
{
    static void Main()
    {
        int num;
        
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        if(num >= 0)
            Console.WriteLine("It is positive or zero");
        else
            Console.WriteLine("It is negative");
    }
}
