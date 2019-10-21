// Daniel Contreras
// char + for

using System;

class CharsAndFor
{
    public static void Main()
    {
        char letter;

        Console.Write("Enter an uppercase letter: ");
        letter = Convert.ToChar(Console.ReadLine());

        for (char c = letter; c <= 'Z'; c++)
        {
            Console.Write("{0} ", c);
        }
    }
}

