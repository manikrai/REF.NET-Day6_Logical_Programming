using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Programming
{
    internal class Perfect_Number
    {
        public static void perfect()
        {
            int number, sum = 0, n,i;
            Console.WriteLine("Enter the Number");
            number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            n = number;
            for( i =1; i<number; i++)
            {
                if(number%i==0)
                {
                    sum=sum+i;
                }

            }
            if(sum==n)
            {
                Console.WriteLine(number+", is a Perfect number");
                
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(number+", is not a Perfect number");
            }
            
            Console.WriteLine(sum+" = "+n) ;
        }
    }
}
