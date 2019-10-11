//Ruth Martínez Iborra
//Cantidad de Múltiplos

using System;

class Multiplos
{
    static void Main()
    {
        int a, b, amountOfMultiplesOf3;
        Console.Write("Enter a: ");
        a = Convert.ToInt32(Console.ReadLine());

        if (a % 3 == 0)
            amountOfMultiplesOf3 = 1;
        else
            amountOfMultiplesOf3 = 0;
        Console.WriteLine("Multiples of 3 so far: {0} ",
            amountOfMultiplesOf3);
            
        amountOfMultiplesOf3 = a % 3 == 0 ? 1 : 0;
        Console.WriteLine("Multiples of 3 so far: {0} ",
            amountOfMultiplesOf3);


        Console.Write("Now Enter b: ");
        b = Convert.ToInt32(Console.ReadLine());

        if (a % 3 == 0 && b % 3 == 0)
            amountOfMultiplesOf3 = 2;
        else if (a % 3 == 0 || b % 3 == 0)
            amountOfMultiplesOf3 = 1;
        else
            amountOfMultiplesOf3 = 0;
            
        Console.WriteLine("Multiples of 3: {0} ",
            amountOfMultiplesOf3);

        amountOfMultiplesOf3 = a % 3 == 0 && b % 3 == 0 ? 
            2 :
            a % 3 == 0 || b % 3 == 0 ? 
                1 : 
                0;
            
        Console.WriteLine("Multiples of 3: {0} ",
            amountOfMultiplesOf3);
    }
}
