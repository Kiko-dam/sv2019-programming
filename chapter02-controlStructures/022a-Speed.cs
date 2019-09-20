// Speed units

using System;

class Speed
{
    static void Main()
    {
        int meters, seconds;
        int mps, kph;
        
        Console.Write("Enter the meters: ");
        meters = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the seconds: ");
        seconds = Convert.ToInt32(Console.ReadLine());
        
        mps = meters / seconds;
        kph = meters * 3600 / seconds / 1000;
        Console.WriteLine("The speed is {0} meters per second", 
            mps);
        Console.WriteLine("And {0} kilometers per hour", 
            kph);
    }
}
