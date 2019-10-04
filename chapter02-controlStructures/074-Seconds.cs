// Seconds to HH:MM:SS

using System;

class Seconds
{
    static void Main()
    {
        int totalSeconds, secondsAfterHours;
        int hours, minutes, seconds;

        Console.Write("Enter amount of seconds: ");
        totalSeconds = Convert.ToInt32(Console.ReadLine());

        hours = totalSeconds / (60 * 60);
        secondsAfterHours = totalSeconds % (60 * 60);
        minutes = secondsAfterHours / 60;
        seconds = secondsAfterHours % 60;

        if (hours < 10)
            Console.Write(0);
        Console.Write(hours);

        Console.Write(":");
        if (minutes < 10)
            Console.Write(0);
        Console.Write(minutes);

        Console.Write(":");
        if (seconds < 10)
            Console.Write(0);
        Console.Write(seconds);

    }
}
