using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            string enter;
            string[][] tape = new string[3][];
            for (int i = 0; i < tape.Length; i++)
            {
                tape[i] = new string[tape.Length];
            }
            for (int i = 0; i < tape.Length; i++)
            {
                Console.WriteLine("Enter your name, last name and more");
                enter = Console.ReadLine();
                int a = 0;
                tape[i][a] = enter.Substring(0, enter.IndexOf(" "));
                tape[i][++a] = enter.Substring(enter.IndexOf(" ") + 1, enter.LastIndexOf(" ") - enter.IndexOf(" ") - 1);
                tape[i][++a] = enter.Substring(enter.LastIndexOf(" ") + 1, enter.Length - enter.LastIndexOf(" ") - 1);
            }
            Console.Write("What do you want to find: ");
            string ask = Console.ReadLine();
            for (int i = 0; i < tape.Length; i++)
            {
                for (int k = 0; k < tape.Length; k++)
                {
                    if (tape[i][k].StartsWith(ask))
                    {
                        for (k = 0; k < tape.Length; k++)
                        {
                            Console.Write(tape[i][k] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
