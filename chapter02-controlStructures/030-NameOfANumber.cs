// Pablo Conde
// Name of a number

using System;

class NameOfANumber
{
    static void Main()
    {
        int number;
        
        Console.Write("Entre a number from 1 to 4: ");
        number = Convert.ToInt32(Console.ReadLine());
      
        switch (number)
        {
            case 1: 
                Console.Write("One");
                break;
            case 2: 
                Console.Write("Two");
                break;
            case 3: 
                Console.Write("Three");
                break;
            case 4: 
                Console.Write("Four");
                break;
            default: 
                Console.Write("It is not a valid number"); 
                break;
        }
    }
}
