// Daniel Contreras
// char + for

using System;

class CharsAndFor
{
    public static void Main()
    {
        char letter;

        do
        {
            Console.Write("Enter an uppercase letter: ");
            letter = Convert.ToChar(Console.ReadLine());
        }
        while (letter < 'A' || letter > 'Z');
    

        for (char c = letter; c <= 'Z'; c++)
        {
            Console.Write("{0} ", c);
        }
    }
}

