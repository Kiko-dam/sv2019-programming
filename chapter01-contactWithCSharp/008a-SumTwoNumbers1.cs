using System;

class SumTwoNumbers1
{
    static void Main()
    {
        int a;
        int b;
        int sum;
        
        Console.WriteLine("Enter a number:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number:");
        b = Convert.ToInt32(Console.ReadLine());
        
        sum = a + b;
        Console.WriteLine("Their sum is:");
        Console.WriteLine(sum);
    }
}
