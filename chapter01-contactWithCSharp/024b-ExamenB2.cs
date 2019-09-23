/* Gonzalo Arques
 * 20/09/2019 */

/*
Crea un conversor de unidades de peso en C#, que pida al usuario la cantidad de 
"libras" (un número entero) y muestre las equivalencia en onzas y en gramos, 
usando las conversiones: "onzas = libras x 16" y "gramos = libras x 453,592". 
Debes usar una variable llamada "onzas" y otra llamada "gramos". El programa 
deberá tener un comentario de dos líneas al principio, para indicar el nombre 
del autor y la fecha de realización. Deberás emplear "using System" y "{0}".

Ejemplo de ejecución (que se debe seguir):

Introduce el peso en libras: 5
5 libras son 80 onzas
5 libras son 2265 gramos
*/

using System;

class Conversor
{
    static void Main ()
    {
        int libras;
        int onzas, gramos;
        
        Console.Write("Introduce el peso en libras: ");
        libras = Convert.ToInt32(Console.ReadLine());
        
        onzas = libras * 16;
        gramos = libras *  453592 / 1000;
        
        Console.WriteLine("{0} libras son {1} onzas",
            libras, onzas);
        Console.WriteLine("{0} libras son {1} gramos",
            libras, gramos);
    }
}
