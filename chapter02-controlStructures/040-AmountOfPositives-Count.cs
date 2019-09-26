using System;

class HowManyPositiveNumbers2
{
    static void Main()
    {
        int n1, n2;
        Console.Write("Enter a number: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        
        int amountOfPositives = 0;
        if (n1 > 0)
            amountOfPositives = amountOfPositives + 1;
        if (n2 > 0)
            amountOfPositives = amountOfPositives + 1;

        Console.WriteLine("Positive: {0}", amountOfPositives);
    }
}
