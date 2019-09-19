// Avelino Martinez Rodriguez
// Time table

using System;

class TimesTable
{
    static void Main()
    {
        int number;
     
        Console.Write("Enter a number for its times table: ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} x 0  = {1}",number, number*0);
        Console.WriteLine("{0} x 1  = {1}",number, number*1);
        Console.WriteLine("{0} x 2  = {1}",number, number*2);
        Console.WriteLine("{0} x 3  = {1}",number, number*3);
        Console.WriteLine("{0} x 4  = {1}",number, number*4);
        Console.WriteLine("{0} x 5  = {1}",number, number*5);
        Console.WriteLine("{0} x 6  = {1}",number, number*6);
        Console.WriteLine("{0} x 7  = {1}",number, number*7);
        Console.WriteLine("{0} x 8  = {1}",number, number*8);
        Console.WriteLine("{0} x 9  = {1}",number, number*9);
        Console.WriteLine("{0} x 10 = {1}",number, number*10);
    }
}
