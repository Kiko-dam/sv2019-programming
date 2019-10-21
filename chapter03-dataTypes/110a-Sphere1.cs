//Avelino Martinez Rodriguez
//esfera

using System;

class Sphere
{
    static void Main()
    {
        float radius, pi = 3.1416f, area, volume;
        Console.Write("Enter the radius: ");
        radius = Convert.ToSingle(Console.ReadLine());

        area = 4 * pi * radius * radius;
        volume = 4.0f / 3.0f * pi * radius * radius * radius;

        Console.WriteLine("Area = {0}", area.ToString("0.00"));
        Console.WriteLine("Volume = {0}", volume.ToString("N2"));
    }
}
