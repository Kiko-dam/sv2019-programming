// Versión  Fecha     Por + cambios
// -------  --------  ------------------------------------
// 0.01     17-10-19  Cristina Francés: Menú principal

using System;

class MenuPrincipal
{
    static void Main()
    {
        byte opcion;
        
        do
        {
            Console.WriteLine("1. Añadir un gasto ");
            Console.WriteLine("2. Ver informes ");
            Console.WriteLine("3. Buscar ");
            Console.WriteLine("0. Salir ");
            opcion = Convert.ToByte(Console.ReadLine());
            
            switch (opcion)
            {
                case 1: 
                case 2:
                case 3:
                    Console.WriteLine("Opción todavía no disponible");
                    break;
                case 0:
                    Console.WriteLine("Hasta otra!");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
            
        } while ( opcion != 0 );
    }
}
