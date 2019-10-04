// Pablo y Hugo

using System;

class Mayor3Numeros

{
    static void Main ()
    {
        int n1, n2, n3, mayor;
        
        Console.Write("Dime el primer número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Dime el segundo número: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Dime el tercer número: ");
        n3 = Convert.ToInt32(Console.ReadLine());

        /*
        if (n1 >= n2 && n1 >= n3)
            mayor = n1;
        else if (n2 >= n1 && n2 >= n3)
            mayor = n2;
        else
            mayor = n3;
        */

        mayor = n1 >= n2 && n1 >= n3 ? 
            n1 : 
            (n2 >= n1 && n2 >= n3 ? 
                n2 : 
                n3);

            
        Console.WriteLine("El número mayor es {0}", mayor);
    }
}
