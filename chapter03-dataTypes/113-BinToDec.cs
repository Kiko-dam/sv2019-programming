// Sergio Gumpert
// Binary to decimal

using System;

class BinToDec
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        Console.WriteLine("Decimal: {0}",
            Convert.ToInt32(Console.ReadLine(), 2) );
    }
}
