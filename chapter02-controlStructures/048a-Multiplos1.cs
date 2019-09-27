// Múltiplo de 2 y de 3?
// Jose Valera

using System;
class Multiplos
{
    static void Main()
    {
        int numero;
        
        Console.Write("Dime un número: ");
        numero = Convert.ToInt32(Console.ReadLine());
        
        if (numero % 2 == 0 && numero % 3 == 0)
            Console.WriteLine("Es múltiplo de 2 y de 3");
        else if (numero % 2 == 0)
            Console.WriteLine("Es múltiplo de 2");
        else if (numero % 3 == 0)
            Console.WriteLine("Es múltiplo de 3");
        else
            Console.WriteLine("No es múltiplo de 2 ni de 3");
    }
}

