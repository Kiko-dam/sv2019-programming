// Lautaro Álvaro Fernández

/*
Crea un programa en C# que pida al usuario dos números enteros, los guarde en 
variables llamadas "num1" y "num2", calcule el resultado de dividir num1 entre 
num2 y lo guarde en una variable llamada "division" y el resto de dicha 
división lo almacene en una variable llamada "resto". No deberá emplearse 
"using System" ni "{0}". Debe haber al principio un comentario de una línea, 
con tu nombre.

Ejemplo de ejecución (que se debe seguir):

Introduce un número: 23
Introduce otro número: 3
Su división es: 7
El resto de la división es: 2
*/

class examenA
{
    static void Main()
    {
        int num1, num2;
        int division, resto;
        
        System.Console.Write("Introduce un número: ");
        num1 = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Introduce otro número: ");
        num2 = System.Convert.ToInt32(System.Console.ReadLine());
        division = num1 / num2;
        resto = num1 % num2;
        System.Console.Write("Su división es: ");
        System.Console.WriteLine(division);
        System.Console.Write("El resto de la división es: ");
        System.Console.WriteLine(resto);
    }
}
