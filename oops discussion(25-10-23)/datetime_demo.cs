using System;
namespace  P1
{
    class demo
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime DateTimeProperty = new DateTime(2001, 8, 24, 7, 10, 24); 

            Console.WriteLine("Day:{0}", DateTimeProperty.Day); 

            Console.WriteLine("Month:{0}", DateTimeProperty.Month); 

            Console.WriteLine("Year:{0}", DateTimeProperty.Year); 

            Console.WriteLine("Hour:{0}", DateTimeProperty.Hour); 

            Console.WriteLine("Minute:{0}", DateTimeProperty.Minute); 

            Console.WriteLine("Second:{0}", DateTimeProperty.Second); 

            Console.WriteLine("Millisecond:{0}", DateTimeProperty.Millisecond); 

 

            Console.WriteLine("Day of Week:{0}", DateTimeProperty.DayOfWeek); 

            Console.WriteLine("Day of Year: {0}", DateTimeProperty.DayOfYear); 

            Console.WriteLine("Time of Day:{0}", DateTimeProperty.TimeOfDay); 

            Console.WriteLine("Tick:{0}", DateTimeProperty.Ticks); 

            Console.WriteLine("Kind:{0}", DateTimeProperty.Kind);
        }
    }
    
}