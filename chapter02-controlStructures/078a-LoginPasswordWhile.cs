// Joel Martinez

using System;

class login
{
    static void Main()
    {
      int log, pass;
      
        Console.Write("Introduce tu usuario: ");
        log = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce tu contraseña: ");
        pass = Convert.ToInt32(Console.ReadLine());
  
  
        while ((log != 1493) || (pass != 1234))
        {
            Console.WriteLine("Datos Incorrectos");
            Console.Write("Introduce tu usuario: ");
            log = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce tu contraseña: ");
            pass = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Datos Correctos");
    }
}
