// Miles to meters
// ( V2: {0} and {1} )

using System;

class MilesToMeters
{
    static void Main()
    {
        int miles, meters;

        Console.WriteLine("How many miles do you want to convert?");
        miles = Convert.ToInt32(Console.ReadLine());

        meters = miles * 1609;

        Console.WriteLine("{0} miles are {1} meters", miles, meters);
    }
}
