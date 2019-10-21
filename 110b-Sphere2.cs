//Avelino Martinez Rodriguez
//esfera

using System;

class Sphere
{
    static void Main()
    {
        float pi = (float) 3.14159265359;
        float radius, area, volume;
        Console.Write("Enter the radius: ");
        radius = Convert.ToSingle(Console.ReadLine());

        area = 4 * pi * radius * radius;
        volume = (float) 4.0 / (float) 3.0 
            * pi * radius * radius * radius;

        Console.WriteLine("Area = {0}", area.ToString("0.00"));
        Console.WriteLine("Volume = {0}", volume.ToString("N2"));
    }
}
