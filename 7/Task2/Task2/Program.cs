using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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
                    Console.WriteLine("Enter: Name and Radius");
                    Circle circle = new Circle(Console.ReadLine(), color.getName(), Convert.ToInt32(Console.ReadLine()));
                    circle.getInfo();
                    break;
                case "2":
                    Console.WriteLine("Enter: Name and All 3 Sides");
                    Triangle triple = new Triangle(Console.ReadLine(), color.getName(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    triple.getInfo();
                    break;
                case "3":
                    Console.WriteLine("Enter: Name and 1 Sides");
                    Square sqr = new Square(Console.ReadLine(), color.getName(), Convert.ToInt32(Console.ReadLine()));
                    sqr.getInfo();
                    break;
                case "4":
                    Console.WriteLine("Bye");
                    break;
            }
            Console.ReadKey();
        }
    }
    class Circle
    {
        private string name;
        private string colore;
        private int radius;
        private double area;
        public Circle(string name, string colore, int radius)
        {
            this.name = name;
            this.colore = colore;
            this.radius = radius;
            this.area = 3.14 * Math.Pow(radius, 2);
        }
        public void getInfo()
        {
            Console.WriteLine("Name: " + name + "\nColore: " + colore + "\nRadius: " + radius + "\nArea of circle: " + area);
        }
    }
    class Triangle
    {
        private string name;
        private string colore;
        private int side1;
        private int side2;
        private int side3;
        double perimetr;

        public Triangle(string name, string colore, int side1, int side2, int side3)
        {
            this.name = name;
            this.colore = colore;
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            perimetr = 0.5 * (side1 + side2 + side3);
        }
        public void getInfo()
        {
            Console.WriteLine("Name:" + name + "\nColore: " + colore + "\nSide01: " + side1 +
                "\nSide02: " + side2 + "\nSide03: " + side3 + "\nPerimetr: " + perimetr);
        }
    }
    class Square
    {
        private string name;
        private string colore;
        private int side1;
        double perimetr;
        public Square(string name, string colore, int side1)
        {
            this.name = name;
            this.colore = colore;
            this.side1 = side1;
            perimetr = 4 * side1;
        }
        public void getInfo()
        {
            Console.WriteLine("Name:" + name + "\nColore: " + colore + "\nSide01: " + side1 +
                "\nPerimetr: " + perimetr);
        }
    }
    class Colore
    {
        private string[] colores = new []{ "Red", "Blue", "Green", "Grey", "Yellow", "Purple", "Black", "Brown", "Orange", "Pink" };
        private string name;
        Random rnd = new Random();
        public string getName()
        {
            return name = colores[rnd.Next(0,10)];
        }
    }
}