using System;

class NumberE
{
    static void Main()
    {
        ulong terms;

        Console.WriteLine(" e Estimator");
        Console.WriteLine("-------------");
        Console.WriteLine();

        Console.Write("Enter the amount of terms: ");
        terms = Convert.ToUInt64(Console.ReadLine());

        if (terms <= 0)
        {
            Console.WriteLine(0);
        }
        else if (terms == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            double result = 1;
            for (ulong i = 1; i < terms; i++)
            {
                double currentTerm = 1;
                for (ulong n = 1; n <= i; n++)
                {
                    currentTerm /= n;
                }
                result += currentTerm;
            }
            Console.WriteLine(result);
        }
    }
}
