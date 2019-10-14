//Ruth Martínez Iborra

/*
Crea un programa que reciba un entero de la entrada estándar y escriba 
"Hola mundo." tantas veces como indique ese número.

Entrada de ejemplo

3

Salida de ejemplo

Hola mundo.
Hola mundo.
Hola mundo.
*/

using System;

class HolaMundo
{
    static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Hola mundo.");
        }
    }
}
