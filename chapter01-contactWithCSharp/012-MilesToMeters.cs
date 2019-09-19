// Miles to meters
// Pablo Vigara

using System;

class MilesToMeters
{
    static void Main()
    {
        int miles, meters;

        Console.WriteLine("How many miles do you want to convert?");
        miles = Convert.ToInt32(Console.ReadLine());

        meters = miles * 1609;

        Console.Write(miles);
        Console.Write(" miles are ");
        Console.Write(meters);
        Console.WriteLine(" meters ");
    }
}
