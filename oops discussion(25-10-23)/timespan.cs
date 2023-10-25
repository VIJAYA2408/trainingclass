using System;

namespace timespan{
    class newtimespan{
        static void Main(String[] args)
        {
            DateTime launchDate = new DateTime(2020, 3, 15, 9, 0, 0);
            DateTime now = DateTime.Now;
            
            // Calculate the interval between the two dates.
            TimeSpan ts = launchDate - now;
            
            Console.WriteLine("TimeSpan: {0}", ts.ToString());
            
            // TimeSpan properties
            Console.WriteLine("Days: {0}", ts.Days);
            Console.WriteLine("Total Number of Days: {0}", ts.TotalDays);
            Console.WriteLine("Hours: {0}", ts.Hours);
            Console.WriteLine("Total number of hours: {0}", ts.TotalHours);
            Console.WriteLine("Minutes: {0}", ts.Minutes);
            Console.WriteLine("Total Number of Minutes: {0}", ts.TotalMinutes);
            Console.WriteLine("Seconds: {0}", ts.Seconds);
            Console.WriteLine("Total Number of Seconds: {0}", ts.TotalSeconds);
            Console.WriteLine("Milliseconds: {0}", ts.Milliseconds);
            Console.WriteLine("Total Number of Milliseconds: {0}", ts.TotalMilliseconds);
            Console.WriteLine("Ticks: {0}", ts.Ticks);
        
            
        }
    }
}