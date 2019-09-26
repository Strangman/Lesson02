using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] month = new int[12];
            int i = 0;
            do
            {
                month[i] = 28 + (++i + (i / 8)) % 2 + 2 % i + 2 * (1 / i);
            } while (i < month.Length);
            i = 0;
            do
            {
                Console.WriteLine("There is " + month[i] + " days in " + ++i + " month");
            } while (i < month.Length);
            Console.ReadKey();
        }
    }
}
