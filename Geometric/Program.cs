using System;
using Geometric.Model;

namespace Geometric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Square example
            float side = 10;
            Square square = new Square(side);
            Console.WriteLine("Square:");
            Console.WriteLine("Perimeter: " + square.CalculatePerimeter());
            Console.WriteLine("Area: " + square.CalculateArea());

            // Rectangle example
            float lengthRect = 15;
            float widthRect = 10;
            Rectangle rectangle = new Rectangle(lengthRect, widthRect);
            Console.WriteLine("Rectangle:");
            Console.WriteLine("Perimeter: " + rectangle.CalculatePerimeter());
            Console.WriteLine("Area: " + rectangle.CalculateArea());
            
            // Parallelogram example
            float lengthPara = 10;
            float widthPara = 5;
            float angle = 30; // Angle in degrees

            Parallelogram parallelogram = new Parallelogram(lengthPara, widthPara, angle);
            Console.WriteLine("Parallelogram:");
            Console.WriteLine("Perimeter: " + parallelogram.CalculatePerimeter());
            Console.WriteLine("Area: " + parallelogram.CalculateArea());
            
            // Trapezoid example
            float bottomTrap = 10;
            float side1Trap = 5;
            float topTrap = 7;
            float side2Trap = 5;

            Trapazoid trapazoid = new Trapazoid(bottomTrap, side1Trap, topTrap, side2Trap);
            Console.WriteLine("Trapezoid:");
            Console.WriteLine("Perimeter: " + trapazoid.CalculatePerimeter());
            Console.WriteLine("Area: " + trapazoid.CalculateArea());
        }
    }
}