// Multiple of 10?

using System;

public class MultipleOfTen
{
    public static void Main()
    {
        Console.Write("How many lines? ");
        int lines = Convert.ToInt32(Console.ReadLine());
        
        for (int line = 0; line < lines; line++)
        {
            for(int number = 10; number >= 0; number = number-2)
                Console.Write("{0} ", number);
            Console.WriteLine();
        }
    }
}
