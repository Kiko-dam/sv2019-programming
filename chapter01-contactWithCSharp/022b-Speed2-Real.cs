// Speed units

using System;

class Speed
{
    static void Main()
    {
        int meters, seconds;
        
        Console.Write("Enter the meters: ");
        meters = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the seconds: ");
        seconds = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The speed is {0} meters per second", 
            1.0 * meters / seconds);
        Console.WriteLine("And {0} kilometers per hour", 
            1.0 * meters / seconds * 3.6);
    }
}
