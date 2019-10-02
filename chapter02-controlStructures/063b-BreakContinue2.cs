// Avoiding "break" and "continue"
// Output: 1 2 4 5 1 2

using System;

class NoBreakAndNoContinue
{
    static void Main()
    {
        for(int num=1; num<=5; num++)
        {
            if(num != 3)
                Console.Write("{0} ",num);
        }
        
        for(int num=1; num<=2; num++)
        {
            Console.Write("{0} ",num);
        }
    }
}
