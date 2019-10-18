using System;

class CircumferenceFloat
{
    static void Main()
    {
        float pi, radius, length;

        pi = 3.14159265359f;
        Console.Write("Enter the radius: ");
        radius = Convert.ToSingle(Console.ReadLine());
        length = 2 * pi * radius;
        Console.WriteLine("Length of the circumference: {0} ",
            length);
    }
}
