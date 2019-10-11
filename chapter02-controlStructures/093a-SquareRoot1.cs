// Estimation of a square root
// Sergio Gumpert

using System;
class x
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int square = 0;
        int x = 0;
    
        do
        {
            x++;
            square = x * x ;
        }
        while (square < number);

        if (square == number)
            Console.WriteLine("Your exact square root its: {0}",x);
        else if (square > number)
            Console.WriteLine("Your square root is: {0} (aprox)",x-1);
    }
}
