// Daniel García
// Change

using System;

class CambioDeMonedas
{
    static void Main()
    {
        Console.Write("Importe: ");
        int importe = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Pagado: ");
        int pagado = Convert.ToInt32( Console.ReadLine() );
        
        int vuelta = pagado - importe; 
        
        
        if ( pagado < importe ) 
            Console.Write("Falta dinero.");
        else
        {
                Console.Write("Las vueltas son {0}; ", vuelta);
                
                while ( 50 <= vuelta )
                {
                    Console.Write("50 ");
                    vuelta = vuelta - 50;
                }
                    
                while ( 10 <= vuelta )
                {
                    Console.Write("10 ");
                    vuelta = vuelta - 10;
                }

                while ( 5 <= vuelta )
                {
                    Console.Write("5 ");
                    vuelta = vuelta - 5;
                }
                    
                while ( 2 <= vuelta )
                {
                    Console.Write("2 ");
                    vuelta = vuelta - 2;
                }

                while ( 1 <= vuelta )
                {
                    Console.Write("1 ");
                    vuelta = vuelta - 1;
                }
        }
    }
}
