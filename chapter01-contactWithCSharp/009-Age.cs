/*

Age calculator
Nacho Cabanes

*/

using System;

class AgeCalculator
{
    static void Main()
    {
        int actualAge, apparentAge;
        
        Console.Write("Enter your age: ");
        actualAge = Convert.ToInt32( Console.ReadLine() );
        apparentAge = actualAge - 2;  // Just kidding ;-)
        Console.Write("You look like if you were ");
        Console.Write( apparentAge );
    }
}
