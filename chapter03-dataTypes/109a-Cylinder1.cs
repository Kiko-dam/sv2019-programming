// DAVID BERENGUER ANTON
// cylinder
using System;

class volume
{
    static void Main()
    {
        double radius, height, volume;
        double pi = 3.141659265359;
        
        Console.WriteLine("Enter the radius of base");
        radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height");
        height  = Convert.ToDouble(Console.ReadLine());

        volume = pi * radius * radius * height;
        Console.WriteLine("the volume is : {0}",volume);
    }
}
