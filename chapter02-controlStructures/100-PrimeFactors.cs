// Sergio Gumpert
// Display prime factors of a number

using System;
class PrimeFactors
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num != 0)
        {
            int i = 2;
            while (num != 1)
            {
                if ((num % i) == 0)
                {
                    num = num / i ;
                    Console.Write("{0} · ",i);
                }
                else 
                    i++;
            }
            Console.Write (1);  
        }
        else
        Console.WriteLine("Enter a number bigger than 0");
    }
}
