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

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            //shows both date and time together
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }
    }

}