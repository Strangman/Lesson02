using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Colore color = new Colore();
            Console.WriteLine("Chose you fighter:\n1.Circle\n2.Triangle\n3.Square\n4.Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    Figure circle = new Circle();
                    Console.WriteLine("enter name: ");
                    circle.getName(Console.ReadLine());
                    Console.WriteLine("enter radius: ");
                    circle.setSide(Convert.ToInt32(Console.ReadLine()));
                    circle.getColore(color.getName());
                    circle.getInfo();
                    break;
                case "2":
                    Figure trio = new Triangle();
                    Console.WriteLine("enter name: ");
                    trio.getName(Console.ReadLine());
                    Console.WriteLine("enter side: ");
                    trio.setSide(Convert.ToInt32(Console.ReadLine()));
                    trio.getColore(color.getName());
                    trio.getInfo();
                    break;
                case "3":
                    Figure square = new Square();
                    Console.WriteLine("enter name: ");
                    square.getName(Console.ReadLine());
                    Console.WriteLine("enter side: ");
                    square.setSide(Convert.ToInt32(Console.ReadLine()));
                    square.getColore(color.getName());
                    square.getInfo();
                    break;
                case "4":
                    Console.WriteLine("Bye");
                    break;
            }
            Console.ReadKey();
        }
    }
    class Colore
    {
        private string[] colores = new[] { "Red", "Blue", "Green", "Grey", "Yellow", "Purple", "Black", "Brown", "Orange", "Pink" };
        private string name;
        Random rnd = new Random();
        public string getName()
        {
            return name = colores[rnd.Next(0, 10)];
        }
    }
    class Figure
    {
        public string name;
        public string colore;
        public int side1;
        public void getName(string name)
        {
            this.name = name;
        }
        public void getColore(string colore)
        {
            this.colore = colore;
        }
        public virtual void setSide(int side1)
        {
            this.side1 = side1;
        }
        public virtual void getInfo()
        {
            Console.WriteLine("name: " + name + " colore: " + colore);
        }
    }
    class Circle: Figure
    {
        public override void getInfo()
        {
            Console.WriteLine("name: " + name + " colore: " + colore + " Area: " + 3.14 * Math.Pow(side1, 2));
        }
    }
    class Triangle: Figure
    {
        public override void getInfo()
        {
            Console.WriteLine("name: " + name + " colore: " + colore + " Perimetr: " + (3 * side1));
        }
    }
    class Square: Figure
    {
        public override void getInfo()
        {
            Console.WriteLine("name: " + name + " colore: " + colore + " Perimetr: " + (4 * side1));
        }
    }
}
