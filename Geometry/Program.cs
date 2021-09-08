using System;
using System.Collections.Generic;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(5);
            Rectangle r = new Rectangle(10, 7);
            Parallelogram p = new Parallelogram(3, 5, 20);
            Trapezoid tra = new Trapezoid(10, 9, 8, 9);
            Triangle tri = new Triangle(6, 8);

            //For my list I use the datatype object because there will be different datatypes in the same list
            //The assignment says I have to call the methods in the loop but my teacher told me I could just add the methods into the list instead
            List<Square> classes = new List<Square> { s, r, p, tra, tri };
            foreach (Square item in classes)
            {
                Console.WriteLine($"The perimeter is: {item.Perimeter()}");
                Console.WriteLine($"The area is: {item.Area()}");
            }
        }
    }
}
