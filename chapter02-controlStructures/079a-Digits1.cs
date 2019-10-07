//Francisco Jiménez Velasco
using System;
class HowManyDigits
{
    static void Main()
    {
    
        int num;
        int digits = 1;
    
        Console.Write("Enter a whole number: ");
        num=Convert.ToInt32(Console.ReadLine());
        
        while (num >= 10)
        {
            num = num / 10;
            digits++;
        }
        
        if (num < 10)
            Console.Write("The number has {0} digits.",digits);
     
    }
}
     
