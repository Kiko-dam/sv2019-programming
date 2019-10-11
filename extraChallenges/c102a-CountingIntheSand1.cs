// Pablo José Ferrándiz Navarro
// Counting in the sand: display as many "1" as told

using System;
class Reto2
{
    static void Main () 
    {
        int num;
        
        do
        {
            num = Convert.ToInt32(Console.ReadLine());
            
            for (int times =0; times < num ; times++)
                Console.Write("1");
            Console.WriteLine();
        }
        while (num != 0);
    }
}
