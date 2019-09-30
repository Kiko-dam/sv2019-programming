// Francisco jimenez velasco
// Numeric mark to text mark
// V4: empty cases

using System;

class NotaSwitch
{
    static void Main()
    {        
        Console.Write("Enter your mark: ");
        int mark = Convert.ToInt32 (Console.ReadLine());
        
        switch (mark)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
                Console.Write("Suspenso");
                break;
            case 5:
                Console.Write("Aprobado");
                break;
            case 6:
                Console.Write("Bien");
                break;
            case 7:
            case 8:
                Console.Write("Notable");
                break;
            case 9:
            case 10:
                Console.Write("Sobresaliente");
                break;        
            default:
                Console.Write("Nota incorrecta");
                break;
        }
    }
}
    
    
