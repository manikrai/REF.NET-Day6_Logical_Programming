using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Programming
{
    internal class Reverse_A_Number
    {
        public static void Reverse()
        {
           
            
            int remainder,  n, i = 0;
            int reverse = 0;
            Console.WriteLine("Enter Number To Reverse: ");
            n =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            i = n;
            while(n>0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n /= 10;
            }
            Console.WriteLine("Input Number Is = {0}",i);
            Console.WriteLine("Its Reverse Is = {0}",reverse);
            
        }
    }
}
