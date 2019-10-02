// DAVID BERENGUER ANTON
// Prime number + break


using System;

class Primo
{
    static void Main()
    {
        int num, divider;
        
        Console.WriteLine("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine() );
        
        for(divider = 2; divider <= num; divider++)
        {
            if(num % divider == 0 )
                break;
        }
        
        if(divider == num)
            Console.WriteLine("It is a prime number !!!");
        else
            Console.WriteLine("It is not a prime number !!! ");
    }
}
