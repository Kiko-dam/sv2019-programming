// Multiple of 10?

using System;

public class MultipleOfTen
{
    public static void Main()
    {
        int n, multipleOf10;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());
        
        if (n % 10 == 0)
            multipleOf10 = 1;
        else
            multipleOf10 = 0;
        Console.WriteLine("multipleOf10 = {0}", multipleOf10);
        
        multipleOf10 = n % 10 == 0 ? 1 : 0 ;        
        Console.WriteLine("multipleOf10 = {0}", multipleOf10);
    }
}
