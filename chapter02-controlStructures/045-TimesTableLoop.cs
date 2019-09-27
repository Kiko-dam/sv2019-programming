// Time table

using System;

class TimesTable
{
    static void Main()
    {
        Console.Write("Enter a number for its times table: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        int i = 0;
        while (i <= 10)
        {
            Console.WriteLine("{0} x {1}  = {2}",
                number, i, number*i);
            i = i + 1;
        }
    }
}
