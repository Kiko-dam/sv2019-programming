// Joel Martinez y Gonzalo Arques
// Divisions 

using System;

class Divisions
{
    static void Main()
    {
        int num1, num2;
        int remainder, division;
        
        Console.Write("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if (num2 == 0) 
            Console.Write("I can't divide by zero");
        else
        {
            division = num1 / num2;
            remainder = num1 % num2;
            
            Console.WriteLine("The division is: {0}", division);
            if (remainder == 0)
                Console.WriteLine("(Exact)");
            else
                Console.WriteLine("And the remainder is: {0}", 
                    remainder);
        }
    }
}
