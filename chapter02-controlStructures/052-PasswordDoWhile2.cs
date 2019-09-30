using System;

class PasswordDoWhile2
{
    static void Main()
    {
        int password;
        
        do
        {
            Console.Write("Enter your password: ");
            password = Convert.ToInt32(Console.ReadLine());
            if (password != 1234)
                Console.WriteLine("Wrong attempt!");
        }
        while (password != 1234);

        Console.WriteLine("Welcome!");
    }
}

