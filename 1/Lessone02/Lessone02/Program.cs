using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessone02
{
    class Program
    {
        static void Main(string[] args)
        {
            int beer = 6;
            if (beer >= 60)
            {
                Console.WriteLine("Leffe");
            }
            else if (60 > beer & beer >= 45)
            {
                Console.WriteLine("Bud");
            }
            else if (45 > beer & beer >= 30)
            {
                Console.WriteLine("Stella Artois");
            }
            else if (30 > beer & beer >= 20)
            {
                Console.WriteLine("Chernigivske");
            }
            else if (20 > beer & beer >= 7)
            {
                Console.WriteLine("Obolon");
            }
            else
            {
                Console.WriteLine("Just water)");
            }
            Console.ReadKey();
        }
    }
}
