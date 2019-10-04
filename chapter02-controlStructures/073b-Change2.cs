// Jose Valera, Cambio 50,10,5,2,1.

using System;

class ejercicioExamen
{
    static void Main()
    {
       int importe, pagado, cambio;
       
       Console.Write("Importe: ");
       importe = Convert.ToInt32(Console.ReadLine());
       
       do
       {
        Console.Write("Pagado: ");
        pagado = Convert.ToInt32(Console.ReadLine());
        if (pagado < importe)
            Console.WriteLine("Insuficiente");
       }
       while (pagado < importe);
       
       cambio = pagado - importe;
       
       Console.WriteLine("Su cambio es: {0}", cambio);
       Console.Write("En los siguientes billetes y monedas: ");
       
       
       while (cambio > 1)
       {
            if (cambio >= 50)
            {
                Console.Write("50 ");
                cambio = cambio - 50;
            }
            else if (cambio >= 10)
            {
                Console.Write("10 ");
                cambio = cambio - 10;
            }
            else if (cambio >= 5)
            {
                Console.Write("5 ");
                cambio = cambio - 5;
            }
            else if (cambio >= 2)
            {
                Console.Write("2 ");
                cambio = cambio - 2;
            }
        }
        
        Console.WriteLine(cambio);
    }
}
