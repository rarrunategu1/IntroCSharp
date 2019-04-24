using System;

namespace IntroCSharp
{
    class DateAndTime
    {
        public void dateTime()
        {
            var dateTime = new DateTime(2018, 3, 22);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine("Hour: " +now.Hour);
            //Console.WriteLine("Minute: " +now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            var nextYear = now.AddYears(1);
            Console.WriteLine(nextYear);
            

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            //shows both date and time together
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }

        public void timeSpanner()
        {
            //Creating TimeSpan Objects
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;

            Console.WriteLine("Duration: " +duration);

            //Properties Object
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            //Converts entire time to minutes
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //timeSpan is immutable but you can modify with add or subtract
            //ADD
            //adding 8 minutes to original timespan
            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));

            //SUBTRACT
            //subtracting 3 minutes from original timespan
            Console.WriteLine("Subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //CONVERSION TO STRING 
            Console.WriteLine("ToString: " + timeSpan.ToString());

            //CONVERSION FROM STRING TO TIMESPAN OBJECT
            Console.WriteLine("Parse: "+ TimeSpan.Parse("01:02:03"));
        }
    }

}