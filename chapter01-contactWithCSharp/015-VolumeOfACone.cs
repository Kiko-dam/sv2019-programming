//asking for radius and height and we compute volume

using System;

class computingConeVolume
{
    static void Main()
    {
        int radius, height, volume;
        
        Console.Write("Height: ");
        height = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Radius: ");
        radius = Convert.ToInt32(Console.ReadLine());
    
        volume = 31415 // for PI, using integers
            *radius * radius // radius squared
            * height 
            / 10000    // also for PI, using integers
            / 3;       // one third of ...
        
        Console.WriteLine("Cone volume is: {0}", volume);
    }
}
