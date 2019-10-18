//Daniel García - Festivolandia

using System;

class Festivolandia
{
    static void Main()
    {
        int entradas = Convert.ToInt32( Console.ReadLine() );
        
        for ( int contador = 1 ; contador <= entradas ; contador++ )
        {
            int dia = Convert.ToInt32( Console.ReadLine() );
            int mes = Convert.ToInt32( Console.ReadLine() );
            
            if ( ( dia % 2 == 0 && mes % 2 == 0 ) ||
                ( dia % 2 != 0 && mes % 2 != 0 ) || 
                ( dia == 25 && mes == 12) )
                Console.WriteLine("FESTIVO");
            else
                Console.WriteLine("LABORABLE");
        }
    }
}
