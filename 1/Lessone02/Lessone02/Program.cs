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
            int beer = 20;
            string take;
            if (beer >= 60)
            {
                take = "Leffe";
            }
            else if (60 > beer & beer >= 45)
            {
                take = "Bud";
            }
            else if (45 > beer & beer >= 30)
            {
                take = "Stella Artois";
            }
            else if (30 > beer & beer >= 20)
            {
                take = "Chernigivske";
            }
            else if (20 > beer & beer >= 7)
            {
                take = "Obolon";
            }
            else
            {
                take = "Just water";
            }
            Console.WriteLine(take);
            Console.ReadKey();
        }
    }
}
