// See https://aka.ms/new-console-template for more information
using System;
namespace RectagularClass
{
    public class Rectagular
    {
        public double width, height;
        public Rectagular(double width, double height)
        {
            this.width = width;
            this.height = height;


        }
        public Double Getarea()
        {
            return this.width * this.height;

        }

        public Double GetPerimeter()
        {
            return (this.width + this.height) * 2;
        }
        public string Display()
        {
            return "Rectangle{" + "width=" + width + ", height=" + height + "}";

        }

       public class Program
        {
            public static  void Main(string[] args)
            {
                Console.WriteLine("Enter the width:");
                double width = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height:");
                double height = Double.Parse(Console.ReadLine());
                Rectagular rectangle = new Rectagular(width, height);
                Console.WriteLine("Your Rectangle \n" + rectangle.Display());
                Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
                Console.WriteLine("Area of the Rectangle: " + rectangle.Getarea());
            }

        }
    }




}

