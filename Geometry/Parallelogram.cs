using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    //All I need for this class is a constructor to get the values I need and a method for calculating the area
    class Parallelogram : Square
    {
        public Parallelogram(double a, double b, int angle)
            :base (a)
        {
            this.B = b;
            this.Angle = angle;
        }

        //I can't just calculate sin(20) cause it expects radians and not degrees
        //so the degrees need to be converted to radians first
        public override double Area()
        {
            double area = (A * B)*Math.Sin(20*(Math.PI/180.0));
            return area;
        }
        private int angle;
        public int Angle
        {
            get
            {
                return angle;
            }
            set
            {
                angle = value;
            }
        }
    }
}
