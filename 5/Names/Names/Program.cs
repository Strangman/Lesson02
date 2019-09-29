using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your surname, name and patronimic");
            string enter = Console.ReadLine();
            string surname = enter.Substring(0, enter.IndexOf(" "));
            string name = enter.Substring(enter.IndexOf(" ") + 1, 1);
            string patronimic = enter.Substring(enter.LastIndexOf(" ") + 1, 1);
            Console.WriteLine(surname + " " + name + ". " + patronimic + ".");
            Console.ReadKey();
        }
    }
}
