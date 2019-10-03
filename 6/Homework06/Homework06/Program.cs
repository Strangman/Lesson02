using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework06
{
    class Student
    {
        Random rnd = new Random();
        int tail;
        bool drunk;
        int iq;
        string name = "Oleh";
        string faculty = "Turism";
        public void chage(int a, int b, bool c)
        {
            tail = a;
            iq = b;
            drunk = c;
        }
        public void pass()
        {
            if(drunk && iq<70 || drunk && tail>3 || iq<70 && tail>3)
            {
                Console.WriteLine("ОТЧИСЛЕН");
            }
            else
            {
                drunk = Convert.ToBoolean(rnd.Next(0, 2));
                iq = ( drunk? iq += 0:iq+=10);
            }
        }
        public void getInfo()
        {
            Console.WriteLine("Name: " + name + ", Faculty: " + faculty + ", Tails: " + tail + ", IQ; " + iq + ", Drunk: " + (drunk? "YES":"NO")) ;
        }
        static void Main(string[] args)
        {
            Student student = new Student();
            Random rnd = new Random();
            student.chage(rnd.Next(0, 12), rnd.Next(150), Convert.ToBoolean(rnd.Next(0, 2)));   
            student.pass();
            student.getInfo();
            Console.ReadKey();
        }
    }
}
