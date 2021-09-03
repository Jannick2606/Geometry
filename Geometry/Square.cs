﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square
    {
        //I don't need a b variable for the square itself but it'll come in handy in the rectangle and parallelogram classes
        public Square(double a)
        {
            this.a = a;
            b = a;
        }

        //I know it's a square which means that all sides will have the same length but by changing the formula from a * 4 to a * 2 + b * 2
        //the method will now be useable in Rectangle and parallelogram without having to override it
        public virtual double Perimeter()
        {
            double perimeter = a * 2 + b * 2;
            return perimeter;
        }

        //Just as in the method above I changed the formula from a * a to a * b so the method will be useable in rectangle
        //without overriding it
        public virtual double Area()
        {
            double area = a * b;
            return area;
        }

        //All the variables I need for the calculations in this class as well as the other classes are gathered here
        //In the formulas the sides are called a, b, c or d, so in my opinion those are also fitting names for my variables
        private double a;
        private double b;
        private double c;
        private double d;
        private int angle;

        #region GetSet
        public virtual double A
        { 
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public virtual double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public virtual double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }
        public virtual double D
        {
            get
            {
                return d;
            }
            set
            {
                d = value;
            }
        }

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
        #endregion
    }
}
