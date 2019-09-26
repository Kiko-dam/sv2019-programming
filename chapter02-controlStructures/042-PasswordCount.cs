using System;

class Password
{
    static void Main()
    {
        Console.Write("Enter your password: ");
        int password = Convert.ToInt32(
            Console.ReadLine());
        int attempts = 1;

        while (password != 1234)
        {
            Console.WriteLine("You have used {0} attempts", attempts);
            Console.Write("Enter your password again: ");
            password = Convert.ToInt32(
                Console.ReadLine());
            attempts = attempts + 1;
        }

        Console.WriteLine("Welcome!");
    }
}

