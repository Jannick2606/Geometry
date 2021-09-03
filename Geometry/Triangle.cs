using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Triangle : Square
    {
        public Triangle(double a, double b)
            : base (a)
        {
            this.B = b;
        }
        public override double Perimeter()
        {
            double c = Math.Sqrt(A * A + B * B);
            double perimeter = A + B + c;
            return perimeter;
        }
        public override double Area()
        {
            double area = A * B / 2;
            return area;
        }
    }
}
