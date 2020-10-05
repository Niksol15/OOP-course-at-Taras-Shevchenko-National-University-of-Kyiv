using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    abstract class Triangle
    {
        public Triangle(int firstSide, int secondSide, double initialAngle)
        {
            if (firstSide <= 0 || secondSide <= 0)
            {
                throw new ArgumentException("Side must be greater than 0");
            }
            if (initialAngle <= 0 || initialAngle >= Math.PI)
            {
                throw new ArgumentException("Incorrect Angle");
            }
            a = firstSide;
            b = secondSide;
            angle = initialAngle;
        }
        abstract public double GetPerimetеr();
        abstract public double GetArea();
        protected int a;
        protected int b;
        protected double angle;
    }

    class IsoscelesTriangle: Triangle
    {
        public IsoscelesTriangle(int side, double angle):
            base(side, side, angle)
        {
        }
        public override double GetPerimetеr()
        {
            return 2 * (a + a * Math.Sin(angle / 2)); 
        }
        public override double GetArea()
        {
            return 0.5 * a * a * Math.Cos(angle / 2);
        }
    }

    class RightTriangle: Triangle
    {
        public RightTriangle (int firstSide, int secondSide):
            base(firstSide, secondSide, Math.PI / 2)
        {
        }

        public override double GetArea()
        {
            return a * b;
        }

        public override double GetPerimetеr()
        {
            return a + b + Math.Sqrt(a * a + b * b);
        }
    }
}
