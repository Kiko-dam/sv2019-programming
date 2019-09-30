using System;

class MultipleCounts
{
    static void Main()
    {
        // 1 to 10
        for (int i = 1; i <= 10 ; i++)
            Console.Write("{0} ",i);
        Console.WriteLine();

        // 5 to 50, *5
        for (int i = 1; i <= 10 ; i++)
            Console.Write("{0} ",i*5);
        Console.WriteLine();

        // 5 to 50, +5
        for (int i = 5; i <= 50 ; i = i+5)
            Console.Write("{0} ",i);
        Console.WriteLine();

        // 10 down to 0
        for (int i = 10; i >= 0 ; i = i-1)
            Console.Write("{0} ",i);
        Console.WriteLine();

        // 10 down to 0, compact
        for (int i = 10; i >= 0 ; i--)
            Console.Write("{0} ",i);

        Console.WriteLine();
    }
}

