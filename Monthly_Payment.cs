using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Programming
{
    internal class Monthly_Payment
    {
        public static void Payment()
        {
             int P, Y;
            int R;
            Console.WriteLine("Enter The Principle Loan Amount");
            P =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter The Years To Pay Off ");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter The Interset Rate ");
            R = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int n = 12 * Y;
            int r = R / (12 * 100);
            double payment=P * r / 1 - ( 1 + r ) ^ (-n);
            Console.WriteLine("Monthly Amount For Payment Will be: ,"+payment);


        }
    }
}
