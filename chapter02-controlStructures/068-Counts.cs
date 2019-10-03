// Count using for, while, do-while

using System;

class Counts
{
    static void Main()
    {
        int n1, n2;
        int i;

        Console.Write("Enter a number: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        if (n1 % 2 == 0)
        {
            Console.WriteLine("Should be and odd number");
        }
        else
        {
            Console.Write("Enter another number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
        
            for (i = n1; i <= n2; i++)
            {
                if (i % 2 != 0)
                    Console.Write("{0} ", i);
            }
            Console.WriteLine();

            for (i = n1; i <= n2; i = i + 2)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            i = n1;
            while (i <= n2)
            {
                Console.Write("{0} ", i);
                i = i + 2;
            }
            Console.WriteLine();

            i = n1;
            do
            {
                Console.Write("{0} ", i);
                i = i + 2;
            } 
            while (i <= n2);
            Console.WriteLine();
        }
    }
}
