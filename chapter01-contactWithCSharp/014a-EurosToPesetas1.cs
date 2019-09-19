// Euros to pesetas

using System;

class EurosToPesetas
{
    static void Main()
    {
        int euros, pesetas;

        Console.WriteLine("How many euros do you want to convert?");
        euros = Convert.ToInt32( Console.ReadLine() );

        pesetas = euros * 166;

        Console.WriteLine("{0} euros are {1} pesetas", 
            euros, pesetas);
    }
}
