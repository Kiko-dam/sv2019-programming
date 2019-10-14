// Jose Valera

using System;

class MenorDe3
{
    static void Main ()
    {
        int n1, n2, n3, menor;
        
        Console.Write("Primer número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Segundo número: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Tercer número: ");
        n3 = Convert.ToInt32(Console.ReadLine());
        
        if (n1 <= n2 && n1 <= n3)
            menor = n1;
        
        else if (n2 <= n3)
            menor = n2;
        
        else
            menor = n3;
            
        Console.WriteLine("El menor es {0}", menor);
        
        menor = 0;
        
        menor = (n1 <= n2 && n1 <= n3)? 
            n1: 
                (n2 <= n3)? 
                    n2:
                    n3;
        Console.WriteLine("El menor es {0}", menor);
    }
}
