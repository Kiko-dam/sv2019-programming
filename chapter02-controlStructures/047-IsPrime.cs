// Is a number prime?

using System;

class IsPrime
{
    static void Main()
    {
        int number, i;
        int amount = 0;
        
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        
        i = 1;
        while (i <= number)
        {
            if (number % i == 0)
                amount = amount + 1;
            
            i = i + 1;
        }
        
        if (amount == 2)
            Console.WriteLine("It is a prime number");
        else
            Console.WriteLine("It is not a prime number");
    }
}
