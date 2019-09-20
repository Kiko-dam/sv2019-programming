// Diego Aníbal Lezcano Reissner
using System;

class PositiveOrNegativeOrZero
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
            Console.WriteLine("The number is positive.");

        if (number < 0)
            Console.WriteLine("The number is negative.");

        if (number == 0)
            Console.WriteLine("The number is zero.");
    }
}

