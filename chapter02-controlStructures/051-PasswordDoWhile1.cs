using System;

class PasswordDoWhile1
{
    static void Main()
    {
        int password;
        
        do
        {
            Console.Write("Enter your password: ");
            password = Convert.ToInt32(Console.ReadLine());
        }
        while (password != 1234);

        Console.WriteLine("Welcome!");
    }
}

