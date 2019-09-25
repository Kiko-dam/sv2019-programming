using System;

//Jose Valera

class GreatestNumber
{
    static void Main()
    {
        int n1, n2, greatest;

        Console.Write("Enter a number: ");
        n1=Convert.ToInt32(Console.ReadLine() );
        Console.Write("Enter another: ");
        n2=Convert.ToInt32(Console.ReadLine() );

        if (n1 >= n2)
            greatest = n1;
        else
            greatest = n2;
        
        Console.Write("The greatest number is: ");
        Console.WriteLine(greatest);
        
        greatest = n1 >= n2 ? n1 : n2;
        
        if (n1 >= n2)
            greatest = n1;
        else
            greatest = n2;
        
        Console.Write("The greatest number is: ");
        Console.WriteLine(greatest);
    }
}
