// DAVID BERENGUER ANTON
// cylinder
using System;

class volume
{
    static void Main()
    {
        double pi = 3.141659265359;
        
        Console.WriteLine("Enter the radius of base");
        double radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height");
        double height  = Convert.ToDouble(Console.ReadLine());

        double volume = pi * radius * radius * height;
        Console.WriteLine("the volume is : {0}",volume);
    }
}
