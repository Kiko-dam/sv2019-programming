// Estimation of a square root
// Pablo Vigara Fernández

using System;

class raiz

{
    static void Main ()
    {
        int num;
        
        Console.Write("Number? ");
        num = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        
        while (i*i < num)
        {
            i++;
        }
        
        if (i*i == num)
            Console.Write("Square root: {0} (exact)", i);
        else
            Console.Write("Square root: {0} (approx)", i-1);
    }
}
