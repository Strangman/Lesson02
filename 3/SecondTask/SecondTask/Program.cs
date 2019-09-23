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
            int i = 1;
            Random ran = new Random();
            int b = ran.Next(0, 101);
            //Console.WriteLine(b);
            for (int a = 0; a <= 5; a++)
            {
                if (a == 5)
                {
                    Console.WriteLine("LOSE");
                    break;
                }

                Console.Write("Try #" + (i++) + " enter your number:");
                int ans = Convert.ToInt32(Console.ReadLine());
                if (ans == b)
                {
                    Console.WriteLine("WON");
                    break;
                }
                else if (ans < b)
                {
                    Console.WriteLine("Wrong! My number is bigger!");
                }
                else
                {
                    Console.WriteLine("Wrong! My number is less!");
                }

                
            }
            Console.ReadKey();
        }
    }
}
