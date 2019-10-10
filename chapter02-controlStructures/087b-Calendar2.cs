// Pablo Vigara Fernández, 20/09/2019

using System;

class calendario
{
    static void Main ()
    {
        int dias, primer, semana;
        
        Console.Write("Cuántos días tiene el mes? ");
        dias = Convert.ToInt32(Console.ReadLine());
        Console.Write("Que dia empieza el mes? ");
        primer = Convert.ToInt32(Console.ReadLine())-1;
        
        Console.WriteLine();
        Console.WriteLine("  L   M   X   J   V   S   D");
        Console.WriteLine();
        
        for (int espacios = 0; espacios < primer; espacios++)
            Console.Write("    ");
        
        for (int i = 1; i <= dias; i++)
        {
            semana = i + primer;
            
            if (semana == 8 ||semana == 15 |
                semana == 22 || semana == 29 || semana == 36)
            {
                Console.WriteLine();
                Console.WriteLine();
            }
            
            if (i < 10)
                Console.Write(" ");
            Console.Write(" {0} ", i);
        }
    }
}
