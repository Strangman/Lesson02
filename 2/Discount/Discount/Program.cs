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
            int cash = 10;
            byte percent= 0 ;
            float discount = 0;
            if (cash >= 0 & cash < 300)
            {
                percent = 0;
                discount = 0;
            }
            else if (cash >= 300 & 400 > cash)
            {
                percent = 3;
                discount = 0.03f;
            }
            else if (cash >= 400 & 500 > cash)
            {
                percent = 5;
                discount = 0.05f;
            }
            else if (cash >= 500)
            {
                percent = 7;
                discount = 0.07f;
            }
            Console.WriteLine("Your discount is " + percent + "%, total to pay " + (cash - (cash * discount)));
            Console.ReadKey();
        }
    }
}
