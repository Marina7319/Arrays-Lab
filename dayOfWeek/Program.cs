using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOFweek = int.Parse(Console.ReadLine());
            string[] weekDays = {

                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            if (dayOFweek >= 1 && dayOFweek <= 7)
            {
                Console.WriteLine(weekDays[dayOFweek - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
