// Sergio Gumpert
// Numeric mark to text mark
// V3: goto case

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
            case 0: Console.WriteLine("Suspenso"); break;
            case 1: goto case 0;
            case 2: goto case 0;
            case 3: goto case 0;
            case 4: goto case 0;
            case 5: Console.WriteLine("Aprobado"); break;
            case 6: Console.WriteLine("Bien"); break;
            case 7: Console.WriteLine("Notable"); break;
            case 8: goto case 7;
            case 9: goto case 10;
            case 10: Console.WriteLine("Sobresaliente"); break;
            default: Console.WriteLine("Nota incorrecta"); break;
        }
    }
}
