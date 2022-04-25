using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Programming
{
    internal class Temperature_Conversion
    {
        public static void temperature()
        {
            //(C X 9/5)+32=F
            //(F - 32)X 5/9=C


            double farenheit, celsius=36;
            Console.WriteLine("Celsius To Faremheit ," + celsius );

            farenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Farenheit: " + farenheit);
            Console.WriteLine();
            Console.WriteLine("Farenheit To Celsius ," + farenheit);
            celsius = (farenheit - 32) * 5 / 9; 
            Console.WriteLine("Celsius: " + celsius);

            Console.ReadLine();
        }
    }
}
