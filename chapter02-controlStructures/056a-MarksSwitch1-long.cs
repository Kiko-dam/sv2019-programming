// Sergio Gumpert
// Numeric mark to text mark
// V1: Basic example

using System;

class Mark
{
    static void Main ()
    {
        int mark;
        
        Console.Write("Enter your mark: ");
        mark = Convert.ToInt32 (Console.ReadLine());
        
        switch (mark)
        {
            case 0:
                Console.WriteLine("SUSPENSO.");
                break ;
            case 1:
                Console.WriteLine("SUSPENSO.");
                break ;
            case 2:
                Console.WriteLine("SUSPENSO.");
                break ;
            case 3:
                Console.WriteLine("SUSPENSO.");
                break ;
            case 4:
                Console.WriteLine("SUSPENSO.");
                break ;
            case 5:
                Console.WriteLine("APROBADO.");
                break ;
            case 6:
                Console.WriteLine("BIEN.");
                break ;
            case 7:
                Console.WriteLine("NOTABLE.");
                break ;
            case 8:
                Console.WriteLine("NOTABLE.");
                break ;
            case 9:
                Console.WriteLine("SOBRESALIENTE.");
                break ;
            case 10:
                Console.WriteLine("SOBRESALIENTE.");
                break ;
            default:
                Console.WriteLine("NOTA INCORRECTA.");
                break ;
        }
    }
}
