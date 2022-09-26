using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lybrary.Models
{
    public class ArrayAndList
    {
        string[] daysOfWeek = new String[7];
        List<string> weekend = new List<string>();

        public void setDays()
        {
            daysOfWeek[0] = "Sunday";
            daysOfWeek[1] = "Monday";
            daysOfWeek[2] = "Tuesday";
            daysOfWeek[3] = "Wednesday";
            daysOfWeek[4] = "Thursday";
            daysOfWeek[5] = "Friday";
            daysOfWeek[6] = "Saturday";

            weekend.Add(daysOfWeek[6]);
            weekend.Add(daysOfWeek[0]);
        }
        public void printDays()
        {
            int count = 1;
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine("Business days:");
                Console.WriteLine($"Day {count}: {day}");
                count++;
            }
            Console.WriteLine("Weekend:");
            foreach (var day in weekend)
            {
                Console.WriteLine($"{day}");
            }
        }
    }
}