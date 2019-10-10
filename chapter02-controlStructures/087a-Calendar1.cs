// DAVID BERENGUER ANTON
// pintar calendario

using System;

class Calendar
{
    static void Main()
    {
        int monthDays, dayOfWeek, spacesDays , numMonth;
        
        Console.Write("How many days have the month?:");
        monthDays = Convert.ToInt32(Console.ReadLine() );
        Console.WriteLine("Enter the day of week that the week begin");
        dayOfWeek = Convert.ToInt32(Console.ReadLine() );
        
        // write days in white before start the month
        for(spacesDays = 1; spacesDays < dayOfWeek; spacesDays++)
        {
            Console.Write("   ");
        }
        
        numMonth = 1;
        while(numMonth <= monthDays)
        {
            if(dayOfWeek > 7)
            {
                Console.WriteLine();
                dayOfWeek = 1;
            }
            if(numMonth < 10)
                Console.Write(" ");
            Console.Write(" {0}", numMonth);
            numMonth ++;
            dayOfWeek ++;
        }
    }
}
