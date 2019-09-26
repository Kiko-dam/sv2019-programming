// Autor: ??? ;-)
// 25/09/2019

/*
Crea un conversor de unidades de presión en C#, que pida al usuario la cantidad
de "milímetros de mercurio" (un número entero) y muestre las equivalencia en
atmósferas y en pascales, usando las conversiones: "1 atm = 760 mm Hg" y "1 atm
= 101325 Pa". Debes usar una variable llamada "mmHg", otra "atm" y otra llamada
"pa". El programa deberá tener dos comentarios de una línea al principio, para
indicar el nombre del autor y la fecha de realización. No deberás emplear
"using System", pero sí "{0}".

Ejemplo de ejecución (que se debe seguir):
Introduce los milímetros de mercurio: 3900
3900 mmHg son 5 atmósferas
3900 mmHg son 519957 pascales
*/

class Examen02
{
    static void Main()
    {
        int mmHg, atm, pa;

        System.Console.Write("Introduce los milímetros de mercurio: ");
        mmHg = System.Convert.ToInt32( System.Console.ReadLine()) ;

        atm = mmHg / 760;
        pa = mmHg * 101325 / 760;
        System.Console.WriteLine("{0} mmHg son {1} atmósferas", mmHg, atm);
        System.Console.WriteLine("{0} mmHg son {1} pascales", mmHg, pa);

        System.Console.WriteLine();
        System.Console.WriteLine("Solución con error de redondeo");
        atm = mmHg / 760;
        pa = atm * 101325;
        System.Console.WriteLine("  {0} mmHg son {1} atmósferas", mmHg, atm);
        System.Console.WriteLine("  {0} mmHg son {1} pascales", mmHg, pa);

        /*
        Nota: se puede optar a medio punto adicional si (usando variables de
        tipo "int") muestras dos líneas adicionales (además de las anteriores)
        que contengan un punto separando de las tres primeras cifras decimales:

        3900 mmHg son 5.132 atmósferas
        3900 mmHg son 519957.237 pascales

        (Este último paso puede fallar con casos como el de 3810 mmHg, que no
        se escriba correctamente como 5.013 atmósferas, pero ese detalle no es
        importante por ahora)
        */

        System.Console.WriteLine("Solucíón con decimales:");
        int parteEnteraAtm = mmHg * 1000 / 760 / 1000;
        int decimalesAtm = mmHg * 1000 / 760 % 1000;
        int parteEnteraPa  = mmHg * 1000 * 101325 / 760 / 1000;
        int decimalesPa    = mmHg * 1000 * 101325 / 760 % 1000;
        System.Console.Write("  {0} mmHg son ", mmHg);
        System.Console.WriteLine("{0}.{1} atmósferas", 
            parteEnteraAtm, decimalesAtm);
        System.Console.Write("  {0} mmHg son ", mmHg);
        System.Console.WriteLine("{0}.{1} pascales", 
            parteEnteraPa, decimalesPa);
        
        System.Console.WriteLine("Desborda con números grandes. Alternativa:");
        long parteEnteraPa2  = mmHg * 1000L * 101325 / 760 / 1000;
        long decimalesPa2    = mmHg * 1000L * 101325 / 760 % 1000;
        System.Console.Write("  {0} mmHg son ", mmHg);
        System.Console.WriteLine("{0}.{1} atmósferas", 
            parteEnteraAtm, decimalesAtm);
        System.Console.Write("  {0} mmHg son ", mmHg);
        System.Console.WriteLine("{0}.{1} pascales", 
            parteEnteraPa2, decimalesPa2);
    }
}
