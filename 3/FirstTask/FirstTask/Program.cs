using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int how = 0;
            int two = 0;
            int three = 0;

            if (num >= 0)
            {
                //How many numbes?
                int o = 1;
                int i = 10;
                 
                while (o > 0)
                {
                    o = num / i;
                    i = i * 10;
                    how++;
                }

                //Summ of numbers that divided by 2
                int b = 0;
                i = 10;
                int g = 1;

                
                for (int a = 0; a < how; a++)
                {
                    b = (num - ((num / i) * i)) / g;
                    i = i * 10;
                    g = g * 10;
                    if (b % 2 == 0)
                    {
                        two = two + b;
                    }
                }
                //How many numbers are divided by 3
                b = 0;
                i = 10;
                g = 1;
                
                for (int a = 0; a < how; a++)
                {
                    b = (num - ((num / i) * i)) / g;
                    i = i * 10;
                    g = g * 10;
                    if (b == 0)
                    {
                        continue;
                    }
                    if (b % 3 == 0)
                    {
                        three++;
                    }
                }
            }
            else
            {
                //How many numbes?
                int o = 1;
                int i = -10;
                
                while (o > 0)
                {
                    o = num / i;
                    i = i * 10;
                    how++;
                }

                //Summ of numbers that divided by 2
                int b = 0;
                i = 10;
                int g = -1;

                
                for (int a = 0; a < how; a++)
                {
                    b = (num - ((num / i) * i)) / g;
                    i = i * 10;
                    g = g * 10;
                    if (b % 2 == 0)
                    {
                        two = two + b;
                    }
                }
                //How many numbers are divided by 3
                b = 0;
                i = 10;
                g = 1;

                for (int a = 0; a < how; a++)
                {
                    b = (num - ((num / i) * i)) / g;
                    i = i * 10;
                    g = g * 10;
                    if (b == 0)
                    {
                        continue;
                    }
                    if (b % 3 == 0)
                    {
                        three++;
                    }
                }
            }
            
            Console.WriteLine(how + "\n" + two + "\n" + three);
            Console.ReadKey();
        }
    }
}
