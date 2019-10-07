//Abraham García
//GoTo

using System;

class CountWithGoto
{
    static void Main()
    {
        int n=1;
        
    repeat:
        Console.WriteLine(n);
        n++;
        if (n<=10)
            goto repeat;
    }
}
