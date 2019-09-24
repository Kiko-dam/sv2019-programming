//Sergio Gumpert

/*
Ask the user for a number and show it on the screen. If it is less than 3 
digits, it must appear with leading zeros until it reaches three digits.
*/

using System;

class Number3Digits
{
    static void Main ()
     {
        int number;

        Console.Write ("Enter a number: ");
        number = Convert.ToInt32 ( Console.ReadLine () );
        
        if (number < 10)
            Console.WriteLine ("00{0}",number);
        else if (number < 100)
            Console.WriteLine ("0{0}",number);
        else
            Console.WriteLine (number);
    }
}
