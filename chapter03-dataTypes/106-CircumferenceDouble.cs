using System;

class Circumference
{
    static void Main()
    {
        double pi, radius, length;
        
        pi = 3.14159265359;
        Console.Write("Enter the radius: ");
        radius = Convert.ToDouble( Console.ReadLine() );
        length = 2*pi*radius;
        Console.WriteLine("Length of the circumference: {0} ", 
            length);
    }
}
