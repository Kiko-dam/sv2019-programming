//Abraham García
//Es múltiplo de...?

using System;

class Mul10
{
    static void Main()
    {
        int n;
        
        Console.Write("Introduce un número del 1 al 10: ");
        n=Convert.ToInt32(Console.ReadLine());
        
        switch (n)
        {
            case 1:
            case 5:
            case 7:
                Console.WriteLine("No es múltiplo ni de 2 ni de 3");
                break;
            case 2:
            case 4: 
            case 8:
            case 10:
                Console.WriteLine("Es múltiplo de 2");
                break;
            case 3:
            case 9:
                Console.WriteLine("Es múltiplo de 3");
                break;
            case 6:
                Console.WriteLine("Es múltiplo de 2 y de 3");
                break;
            default:
                Console.WriteLine("El número no es válido");
                break;
        }
    }
}
