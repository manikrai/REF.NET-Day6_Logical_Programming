using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Programming
{
    internal class Newton_Method

    {
        
        public double Sqrt(int count, double num)
        {
            
            double N;
            double M=num;
            double n=0.00001;
            while(true)
            {
                count++;
                N=0.5*(M+num/M);
                if(Math.Abs(N-M)<n)
                {
                    Console.WriteLine("squareroot of " + num + " is " + N);
                    break;
                }
                M=N;
            }
            return N;

        }
    }
}
