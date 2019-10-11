// Daniel Contreras
// Days in a month

using System;

class DaysInAMonth
{
    static void Main()
    {
        Console.Write("Enter the month number: ");
        int month = Convert.ToInt32(Console.ReadLine());
        
        
        //if
        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8
            || month == 10 || month == 12)
        {
            Console.WriteLine(31);
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11 )
        {
            Console.WriteLine(30);
        }
        else if (month == 2)
        {
            Console.WriteLine(28);
        }
        else
        {
            Console.WriteLine("Wrong month");
        }


        //switch (1)
        switch (month)
        {
            case 1:Console.WriteLine(31);break;
            case 2:Console.WriteLine(28);break;
            case 3:Console.WriteLine(31);break;
            case 4:Console.WriteLine(30);break;
            case 5:Console.WriteLine(31);break;
            case 6:Console.WriteLine(30);break;
            case 7:Console.WriteLine(31);break;
            case 8:Console.WriteLine(31);break;
            case 9:Console.WriteLine(30);break;
            case 10:Console.WriteLine(31);break;
            case 11:Console.WriteLine(30);break;
            case 12:Console.WriteLine(31);break;
            default:Console.WriteLine("Wrong month");break;
        }
        
        
        //switch (2)
        switch (month)
        {
            case 1:Console.WriteLine(31);break;
            case 2:Console.WriteLine(28);break;
            case 3: goto case 1;
            case 4:Console.WriteLine(30);break;
            case 5: goto case 1;
            case 6: goto case 4;
            case 7: goto case 1;
            case 8: goto case 1;
            case 9: goto case 4;
            case 10: goto case 1;
            case 11: goto case 4;
            case 12: goto case 1;
            default:Console.WriteLine("Wrong month");break;
        }
        
        
        //switch (3)
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine(31);
                break;
            case 2:
                Console.WriteLine(28);
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine(30);
                break;
            default:
                Console.WriteLine("Wrong month");
                break;
        }
    }
}

