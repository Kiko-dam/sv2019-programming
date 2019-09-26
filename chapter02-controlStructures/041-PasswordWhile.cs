using System;

class Password
{
    static void Main()
    {
        Console.Write("Enter your password: ");
        int password = Convert.ToInt32(
            Console.ReadLine());

        while (password != 1234)
        {
            Console.Write("Enter your password again: ");
            password = Convert.ToInt32(
                Console.ReadLine());
        }

        Console.WriteLine("Welcome!");
    }
}

