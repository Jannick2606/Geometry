using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    //In this class I need the length of all 4 sides to calculate area and perimeter
    class Trapezoid : Square
    {
        public Trapezoid(double a, double b, double c, double d)
            : base(a)
        {
            this.B = b;
            this.C = c;
            this.D = d;
        }

        public override double Perimeter()
        {
            double perimeter = A + B + C + D;
            return perimeter;
        }
        //Added Math.Abs to ensure I get a positive number even if a is smaller than c
        //otherwise it could calculate the area as -80 when it's supposed to be 80
        public override double Area()
        {
            double s = (A + B - C + D) / 2;
            double h = 2 / (A - C) * Math.Sqrt(s * (s - A + C) * (s - B) * (s - D));
            double area = 0.5 * (A + C) * h;
                return Math.Abs(area);
            
        }
    }
}
