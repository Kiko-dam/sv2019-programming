// Marks, if
// (altenative version)

using System;
class IfMarks
{
    static void Main()
    {
        Console.Write("Enter your mark: ");
        int mark = Convert.ToInt32(Console.ReadLine());
        
        if ((mark > 10) || (mark < 0))
            Console.WriteLine("Wrong mark");
        else if (mark >= 9)
            Console.WriteLine("Sobresaliente");
        else if (mark >= 7)
            Console.WriteLine("Notable");
        else if(mark == 6)
            Console.WriteLine("Bien");
        else if(mark == 5)
            Console.WriteLine("Aprobado");
        else // mark <= 4
            Console.WriteLine("Suspenso");
    }
}
        
