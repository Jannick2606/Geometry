using System;
using System.Linq;
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
            List<object> classes = new List<object> { s.Perimeter(), s.Area(), r.Perimeter(), r.Area(), p.Perimeter(), p.Area(), tra.Perimeter(), tra.Area(), tri.Perimeter(), tri.Area() };
            for (int i = 0; i < classes.Count; i++)
            {
                if(i%2 == 0)
                    Console.WriteLine($"The perimeter is: {classes[i]}");
                else Console.WriteLine($"The area is: {classes[i]}");
            }
        }
    }
}
