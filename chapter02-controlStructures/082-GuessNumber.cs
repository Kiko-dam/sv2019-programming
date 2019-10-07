// Joel Martinez

using System;

class GuessANumber
{
    static void Main()
    {
        int hiddenNumber;
        int userNumber;

        hiddenNumber = 501;
        do
        {
            Console.Write("Enter a number between 0 and 1000: ");
            userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber == hiddenNumber)
                Console.WriteLine("You did it!");
            else if (userNumber > hiddenNumber)
                Console.WriteLine("Too high");
            else
                Console.WriteLine("Too low");
        }
        while (userNumber != hiddenNumber);
    }
}
