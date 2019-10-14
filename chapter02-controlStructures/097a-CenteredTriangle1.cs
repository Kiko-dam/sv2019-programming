//Pablo Miguel Climent Gonzálvez
using System;
class TrianguloCentrado
{
    static void Main()
    {
        Console.Write("Ancho: ");
        int ancho=Convert.ToInt32(Console.ReadLine());
        if (ancho%2!=0)
        {
            for (int i=1; i<=ancho;i+=2)
            {
                for (int j=1 ; j<=((ancho-i)/2) ; j++)
                    Console.Write(" ");
                for (int j=1 ; j<=i ; j++)
                    Console.Write("#");
                for (int j=1 ; j<=((ancho-i)/2) ; j++)
                    Console.Write(" ");
                Console.WriteLine();
            }
        }
        else
        {
            for (int i=2; i<=ancho;i+=2)
            {
                for (int j=1 ; j<=((ancho-i)/2) ; j++)
                    Console.Write(" ");
                for (int j=1 ; j<=i ; j++)
                    Console.Write("#");
                for (int j=1 ; j<=((ancho-i)/2) ; j++)
                    Console.Write(" ");
                Console.WriteLine();
            }
        }
    }
}
