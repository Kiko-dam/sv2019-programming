using System;

class SumTwoNumbers2
{
    static void Main()
    {
        int a, b, sum;
        
        Console.Write("Enter a number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        b = Convert.ToInt32(Console.ReadLine());
        
        sum = a + b;
        Console.Write("Their sum is: ");
        Console.WriteLine(sum);
    }
}
