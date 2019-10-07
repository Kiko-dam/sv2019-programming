// DAVID BERENGUER ANTÓN
// cuantos digitos tiene un numero

using System;

class Digits
{
    static void Main()
    {
        int userNum, currentNum, digits;
        Console.Write("Enter the number:");
        userNum = Convert.ToInt32(Console.ReadLine() );
        
        digits = 0;
        currentNum = userNum;
        
        do
        {
            currentNum = currentNum / 10;
            digits++;
        }
        while( currentNum > 0);
        
        Console.WriteLine("the number {0} has {1} digits",
            userNum, digits);
    }
}
