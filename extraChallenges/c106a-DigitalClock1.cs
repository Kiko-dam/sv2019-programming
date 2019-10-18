//DAVID BERENGUER ANTON
// reto6 digital clock 

// Amount of LEDs lit after n seconds

/*
Sample input
0
4
1000
36000


Sample output
36
172
30630
1069232
*/

using System;

class Reto6
{
    static void Main()
    {
        int h, decenasH, restoH;
        int m, decenasM, restoM;
        int s, decenasS, restoS;
        int sTotal, sRest, ledsH, ledsM, ledsS, leds1, leds2, ledsTot = 0;
        
        sTotal = Convert.ToInt32(Console.ReadLine() );
        for(int veces = 0; veces <= sTotal; veces++)
        {
            h = veces / 3600;
            sRest = veces % 3600;
            m = sRest / 60;
            s = sRest % 60;
            
            if(h < 10)
            {
                switch (h)
                {
                    case 0:
                    case 6:
                    case 9:
                        ledsH = 6;
                        break;
                    case 1:
                        ledsH = 2;
                        break;
                    case 2:
                    case 3:
                    case 5:
                        ledsH = 5;
                        break;
                    case 4:
                        ledsH = 4;
                        break;
                    case 7:
                        ledsH = 3;
                        break;
                    default:
                        ledsH = 7;
                        break;
                }
                ledsH = ledsH + 6;
            }
            else
            {
                decenasH = h / 10;
                restoH = h % 10;
                
                switch (decenasH)
                {
                    case 0:
                    case 6:
                    case 9:
                        leds1 = 6;
                        break;
                    case 1:
                        leds1 = 2;
                        break;
                    case 2:
                    case 3:
                    case 5:
                        leds1 = 5;
                        break;
                    case 4:
                        leds1 = 4;
                        break;
                    case 7:
                        leds1 = 3;
                        break;
                    default:
                        leds1 = 7;
                        break;
                }
                
                switch (restoH)
                {
                    case 0:
                    case 6:
                    case 9:
                        leds2 = 6;
                        break;
                    case 1:
                        leds2 = 2;
                        break;
                    case 2:
                    case 3:
                    case 5:
                        leds2 = 5;
                        break;
                    case 4:
                        leds2 = 4;
                        break;
                    case 7:
                        leds2 = 3;
                        break;
                    default:
                        leds2 = 7;
                        break;
                }
                ledsH = leds1 + leds2;
            }
            
            if(m < 10)
            {
                switch (m)
                {
                    case 0:
                    case 6:
                    case 9:
                        ledsM = 6;
                        break;
                    case 1:
                        ledsM = 2;
                        break;
                    case 2:
                    case 3:
                    case 5:
                        ledsM = 5;
                        break;
                    case 4:
                        ledsM = 4;
                        break;
                    case 7:
                        ledsM = 3;
                        break;
                    default:
                        ledsM = 7;
                        break;
                }
                ledsM = ledsM + 6;
            }
            else
            {
                decenasM = m / 10;
                restoM = m % 10;
                
                switch (decenasM)
                {
                    case 0:
                    case 6:
                    case 9:
                        leds1 = 6;
                        break;
                    case 1:
                        leds1 = 2;
                        break;
                    case 2:
                    case 3:
                    case 5:
                        leds1 = 5;
                        break;
                    case 4:
                        leds1 = 4;
                        break;
                    case 7:
                        leds1 = 3;
                        break;
                    default:
                        leds1 = 7;
                        break;
                }
                
                switch (restoM)
                {
                    case 0:
                    case 6:
                    case 9:
                        leds2 = 6;
                        break;
                    case 1:
                        leds2 = 2;
                        break;
                    case 2:
                    case 3:
                    case 5:
                        leds2 = 5;
                        break;
                    case 4:
                        leds2 = 4;
                        break;
                    case 7:
                        leds2 = 3;
                        break;
                    default:
                        leds2 = 7;
                        break;
                }
                ledsM = leds1 + leds2;
            }
            
            if(s < 10)
            {
                switch (s)
                {
                    case 0:
                    case 6:
                    case 9:
                        ledsS = 6;
                        break;
                    case 1:
                        ledsS = 2;
                        break;
                    case 2:
                    case 3:
                    case 5:
                        ledsS = 5;
                        break;
                    case 4:
                        ledsS = 4;
                        break;
                    case 7:
                        ledsS = 3;
                        break;
                    default:
                        ledsS = 7;
                        break;
                }
                ledsS = ledsS + 6;
            }
            else
            {
                decenasS = s / 10;
                restoS = s % 10;
                
                switch (decenasS)
                {
                    case 0:
                    case 6:
                    case 9:
                        leds1 = 6;
                        break;
                    case 1:
                        leds1 = 2;
                        break;
                    case 2:
                    case 3:
                    case 5:
                        leds1 = 5;
                        break;
                    case 4:
                        leds1 = 4;
                        break;
                    case 7:
                        leds1 = 3;
                        break;
                    default:
                        leds1 = 7;
                        break;
                }
                
                switch (restoS)
                {
                    case 0:
                    case 6:
                    case 9:
                        leds2 = 6;
                        break;
                    case 1:
                        leds2 = 2;
                        break;
                    case 2:
                    case 3:
                    case 5:
                        leds2 = 5;
                        break;
                    case 4:
                        leds2 = 4;
                        break;
                    case 7:
                        leds2 = 3;
                        break;
                    default:
                        leds2 = 7;
                        break;
                }
                ledsS = leds1 + leds2;
            }
            ledsTot = ledsTot + ledsH + ledsM + ledsS;
        }
        Console.WriteLine(ledsTot);
    }
}
