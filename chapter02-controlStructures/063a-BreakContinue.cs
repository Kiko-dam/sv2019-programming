// Avelino Martinez Rodriguez
// Example of "break" and "continue"
// Output: 1 2 4 5 1 2

using System;

class BreakAndContinue
{
    static void Main()
    {
        for(int num=1; num<=5; num++)
        {
            if(num==3)
                continue;
            Console.Write("{0} ",num);
        }
        
        for(int num=1; num<=5; num++)
        {
            if(num==3)
                break;
            Console.Write("{0} ",num);
        }
    }
}
