// Leading zeroes
// Alberto Girón Serna

/*
Ask the user for a number and show it on the screen. If it is less than 3 
digits, it must appear with leading zeros until it reaches three digits.
*/

using System;

class LeadingZeroes
{
    static void Main ()
    {
        int num;

        Console.Write ("Enter a positive number: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        if (num >= 100)
            Console.WriteLine(num);
        else if (num >= 10)
            Console.WriteLine("0{0}", num);
        else if (num >= 0)
            Console.WriteLine("00{0}", num);
        else
            Console.WriteLine("Positive numbers, please");
    }
}
