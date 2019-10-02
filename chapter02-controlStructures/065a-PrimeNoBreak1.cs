//Pablo Miguel Climent Gonzálvez
using System;
class PrimesNoBreak
{
    static void Main()
    {
        int number,dividers=0;
        
        Console.WriteLine("Enter a natural number: ");
        number = Convert.ToInt32(Console.ReadLine() );
        
        Console.Write("Is it a prime number? ");
        int i=1;
        while (( i <= number) && (dividers <= 2))
        {
            if (number % i == 0)
                dividers = dividers+1;
            
            i++;
        }
        if (dividers == 2)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
}
