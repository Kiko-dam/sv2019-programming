// Dividers of a number

using System;

class Dividers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        int i = 1;
        while (i <= number)
        {
            if (number % i == 0)
                Console.WriteLine(i);
            
            i = i + 1;
        }
    }
}
