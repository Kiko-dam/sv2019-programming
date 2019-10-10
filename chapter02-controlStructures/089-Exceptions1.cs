using System;

class SumTwoNumbersExceptions
{
    static void Main()
    {
        int a, b, sum;
        
        try
        {
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            b = Convert.ToInt32(Console.ReadLine());
            
            sum = a + b;
            Console.Write("Their sum is: ");
            Console.WriteLine(sum);
        }
        catch (Exception)
        {
            Console.WriteLine("That is not a valid number");
        }
        
        Console.WriteLine("Have a nice day!");
    }
}
