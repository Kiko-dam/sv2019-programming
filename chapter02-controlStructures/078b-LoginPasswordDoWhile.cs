//Pablo Conde
//Password y usuario con do while

using System;

class PasswordDoWhile
{
    static void Main()
    {
        int usuario, password;
        do
        {
            Console.Write("Introduce el usuario: ");
            usuario = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el password: ");
            password = Convert.ToInt32(Console.ReadLine());
            
            if (usuario != 4321 || password != 1234)
                Console.WriteLine("Acceso denegado");
        }
        while (usuario != 4321 || password != 1234 );
        
        Console.WriteLine();
        Console.WriteLine("¡Bienvenido!");
    }
}
