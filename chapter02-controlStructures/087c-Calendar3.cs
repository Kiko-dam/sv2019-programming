//
//

using System;

class Calendar
{
    static void Main()
    {
        int starterDay, monthDays, space;
        int day;
        
        Console.Write("Enter the number of days: ");
        monthDays = Convert.ToInt32( Console.ReadLine() );
        Console.Write("Enter the starter day: ");
        starterDay = Convert.ToInt32( Console.ReadLine() );
        
        Console.Write("Mon Tue Wed Thu Fri Sat Sun");
        Console.WriteLine();
        
        for(space = 1 ; space < starterDay; space++)
            Console.Write("    ");
        for(day = 1; day <= monthDays; day++)
        {
            starterDay++;
            if(day >= 1 && day < 10)
                Console.Write(" 0{0} ", day);
            else
                Console.Write(" {0} ", day);
            if(starterDay % 7 == 1)
                    Console.WriteLine();
        }
    }
}
