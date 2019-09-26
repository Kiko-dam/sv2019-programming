//Daniel Contreras

using System;

class HowManyPositiveNumbers
{
    static void Main()
    {
        int n1, n2;

        Console.Write("Enter a number: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        if (n1 > 0 && n2 > 0)
        {
            Console.WriteLine("Positive: 2");
        }
        else if (n1 > 0 || n2 > 0)
        {
            Console.WriteLine("Positive: 1");
        }
        else
        {
            Console.WriteLine("Positive: 0");
        }
    }
}
