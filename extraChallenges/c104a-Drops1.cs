/* Jose Valera
 *
Entrada de ejemplo
3
70
3600
3661
Salida de ejemplo
00:01:10
01:00:00
01:01:01
*/

using System;

class goteras
{
    static void Main ()
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < cases; i++)
        {
            int drops = Convert.ToInt32(Console.ReadLine());
        
            int hours, minutes;
            int remainderH, remainderM;
            
            hours = drops / 3600;
            remainderH = drops % 3600;
            
            minutes = remainderH / 60;
            remainderM = remainderH % 60;
                
            if (hours < 10)
                Console.Write(0);
            Console.Write("{0}:", hours);
                
            if (minutes < 10)
                Console.Write(0);
            Console.Write("{0}:", minutes);
                
            if (remainderM < 10)
                Console.Write(0);
            Console.WriteLine(remainderM);
        }

    }
}
