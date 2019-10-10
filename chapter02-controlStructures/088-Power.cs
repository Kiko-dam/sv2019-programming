// Diego Aníbal Lezcano Reissner y Lautaro Álvaro Fernández

using System;

class Exponent
{
    static void Main()
    {
        Console.Write("Enter base: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter exponent: ");
        int exp = Convert.ToInt32(Console.ReadLine());

        int result = 1;
        for (int i = 0; i < exp; i++)
        {
            result = result * n;
        }
        Console.WriteLine("{0} ^ {1} = {2}", n, exp, result);
    }
}
