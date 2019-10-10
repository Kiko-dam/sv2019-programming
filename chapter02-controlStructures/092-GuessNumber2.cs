using System;

class GuessANumber2
{
    static void Main()
    {
        int hiddenNumber, userNumber;
        int maxAttempts = 9, currentAttempt = 0;

        hiddenNumber = DateTime.Now.Millisecond;
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
            
            currentAttempt ++;
            Console.WriteLine("Remaining attempts: {0}",
                maxAttempts - currentAttempt);
        }
        while (userNumber != hiddenNumber 
            && currentAttempt < maxAttempts);
            
        if (userNumber != hiddenNumber)
                Console.WriteLine("Sorry! It was {0}", hiddenNumber);
    }
}
