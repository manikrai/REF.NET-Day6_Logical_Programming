/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Programming
{
    internal class StopWatch_Program
    {
        public static void program()
        {
            Console.WriteLine("Press Any Key to Start The Timer");
            Console.ReadKey();
            Console.WriteLine();
            var watch = StopWatch_Program.StartNew();

            Console.WriteLine("Press Any Key To Exit");
            while(Console.ReadKey().Key != ConsoleKey.Enter)
            {
                watch.Stop();
            }
            Console.WriteLine($"Execution time: {watch.ElapsedMilliseconds} ms");
        }

     
    }
}
*/