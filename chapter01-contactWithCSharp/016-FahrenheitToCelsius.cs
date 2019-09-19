//Sergio Gumpert
//Grados Fº a Cº

using System;

class FahrenheitToCelsius
{
    static void Main () 
    {
        int fahrenheit, celsius;
        Console.Write ("How many fahrenheit degrees? ");
        fahrenheit = Convert.ToInt32(
            Console.ReadLine() );
        celsius = (fahrenheit - 32) * 5 / 9 ;
        Console.WriteLine ("{0}F equals {1}C",
            fahrenheit, celsius);
    }
    
}
