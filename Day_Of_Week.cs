using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Programming
{
    internal class Day_Of_Week
    {
        

        public static void Day()
        {
            int d,m,y;
            Console.WriteLine("Enter Day: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year: ");
            y = Convert.ToInt32(Console.ReadLine());
            DateTime dt = new DateTime(y,m,d);
            Console.WriteLine("The formatted Date is : {0}",dt.ToString("dd/MM/yyyy"));
            DateTime ss;
            ss = DayOfWeek(dt);
            Console.WriteLine("The day for the date is: {0}\n ", ss.DayOfWeek);
        }

        public static DateTime DayOfWeek(DateTime dt)
        {
            DateTime pp = new DateTime(dt.Year, dt.Month, dt.Day);
            return pp;
        }
    }
}
