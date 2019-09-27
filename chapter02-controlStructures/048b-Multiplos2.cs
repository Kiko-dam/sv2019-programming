// Múltiplo de 2 y de 3?

using System;
class Multiplos2
{
    static void Main()
    {
        int numero, multiplo2, multiplo3;
        
        Console.Write("Dime un número: ");
        numero = Convert.ToInt32(Console.ReadLine());
        
        if ((numero == 1) || (numero == 5)  || (numero == 7))
            Console.WriteLine("No es múltiplo de 2 ni 3");
        else if ((numero == 2) || (numero == 4)  || (numero == 8)
                 || (numero == 10))
            Console.WriteLine("Es múltiplo de 2");
        else if (numero == 3)  || (numero == 9)
            Console.WriteLine("Es múltiplo de 3");
        else if (numero == 6)
            Console.WriteLine("Es múltiplo de 2 y de 3");
        else
            Console.WriteLine("Número no válido");
            
            
            
            
            
            
            
            
        
        multiplo2 = numero % 2;
        multiplo3 = numero % 3;
        
        if (multiplo2 == 0 && multiplo3 == 0)
        Console.WriteLine("Esmúltiplo de 2 y de 3");
        
        else if (multiplo2 == 0)
        Console.WriteLine("Es múltiplo de 2");
        
        else
        Console.WriteLine("Es múltiplo de 3");
    }
}

