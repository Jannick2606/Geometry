using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Rectangle : Square
    {
        //Since I changed the formulas in the square class, I just need a constructor with an a and a b variable for this class
        public Rectangle(double a, double b)
            : base(a)
        {
            this.B = b;
        }
    }
}
