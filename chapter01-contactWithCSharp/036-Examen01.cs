/*
Área  y perímetro de un rectángulo
Autor: ??? ;-)

Crea un programa en C# que pida al usuario la anchura y la altura de un 
rectángulo, las guarde en variables enteras llamadas "anchura" y "altura", 
calcule el área y el perímetro de ese rectángulo y los guarde en variables 
llamadas "area" y "perimetro" y finalmente muestre sus valores. Deberás emplear 
"using System", pero no "{0}". Debe haber al principio un comentario de dos 
líneas, una con la descripción del programa ("Área y perímetro de un 
rectángulo") y otra con tu nombre.

Ejemplo de ejecución (que se debe seguir):
Introduce la anchura: 20
Introduce la altura: 6
El área es: 120
El perímetro es: 52
*/

using System;

class Examen01
{
    static void Main()
    {
        int anchura, altura;
        int area, perimetro;

        Console.Write("Introduce la anchura: ");
        anchura = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce la altura: ");
        altura = Convert.ToInt32(Console.ReadLine());

        area = altura * anchura;
        perimetro = 2*anchura + 2*altura;

        Console.Write("El área es: ");
        Console.WriteLine(area);
        Console.Write("El perímetro es: ");
        Console.WriteLine(perimetro);
    }
}
