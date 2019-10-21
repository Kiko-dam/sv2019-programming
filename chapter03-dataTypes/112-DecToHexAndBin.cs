// Sergio Gumpert
// Decimal to hexadecimal and binary

using System;

class DecToHexAndBin
{
    static void Main()
    {
        int num;
        do
        {
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            if (num != 0)
            {
                Console.WriteLine("Your number in binary is {0}", 
                    Convert.ToString(num,2));
                Console.WriteLine("Your number in hexadecimal is {0}", 
                    Convert.ToString(num,16));
            }
        }
        while (num != 0) ;
        Console.WriteLine("Bye!");
    }
}
