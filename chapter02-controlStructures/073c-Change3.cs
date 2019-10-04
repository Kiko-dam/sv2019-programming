//DAVID BERENGUER ANTON
// MAQUINA DE CAMBIO 

using System;

class MaquinaDeCambio
{
    static void Main()
    {
        int importe, pagado;
        int vueltas;
        int dineroActual, dineroRestante;
        Console.Write("importe: ");
        importe = Convert.ToInt32(Console.ReadLine() );
        Console.Write("pagado: ");
        pagado = Convert.ToInt32(Console.ReadLine() ) ;
        
        if(importe > pagado)
            Console.WriteLine ("numeros introducidos incorrectos");
        else
        {
            vueltas = pagado - importe;
            Console.WriteLine ("sus vueltas son {0} euros", vueltas);
            
            for(int i = 50; i >= 1; i--)
            {
                if(i == 50 || i == 10 || i == 5 || i == 2 || i == 1)
                {
                    dineroActual = vueltas / i;
                    dineroRestante = vueltas % i;
                    
                    for(int cuantos=0; cuantos < dineroActual; cuantos++)
                        Console.Write("{0} ",i);
                    vueltas = dineroRestante;
                }
            }
        }
    }
}
