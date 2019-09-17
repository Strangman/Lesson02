using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int cash = 532;
            if (cash < 300)
            {
                Console.WriteLine("Your discount is 0 %, total to pay " + cash);
            }
            else if (cash >= 300 & 400 > cash)
            {
                Console.WriteLine("Your discount is 3 %, total to pay " + (cash-(cash*0.03)));
            }
            else if (cash >= 400 & 500 > cash)
            {
                Console.WriteLine("Your discount is 5 %, total to pay " + (cash - (cash * 0.05)));
            }
            else if (cash >= 500)
            {
                Console.WriteLine("Your discount is 7 %, total to pay " + (cash - (cash * 0.07)));
            }
            Console.ReadKey();
        }
    }
}
