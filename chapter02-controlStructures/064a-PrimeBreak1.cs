//Pablo Miguel Climent Gonzálvez
using System;
class PrimesBreak1
{
    static void Main()
    {
        int number,dividers=0;
        
        Console.WriteLine("Enter a natural number: ");
        number = Convert.ToInt32(Console.ReadLine() );
        
        Console.Write("Is it a prime number? ");
        for (int i=1 ; i <= number ; i++)
        {
            if (number % i == 0)
                dividers = dividers+1;
            
            if (dividers > 2)
                break ;
        }
        if (dividers == 2)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}
