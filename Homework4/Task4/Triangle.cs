using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    class Triangle
    {
        public Triangle(int firstSide, int secondSide, int thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException("One or more sides of a triangle are less than or equal to 0");
            }
            if (firstSide >= secondSide + thirdSide || secondSide >= firstSide + thirdSide || 
                thirdSide >= firstSide + secondSide)
            {
                throw new ArgumentException("Triangle inequality is not fulfilled");
            }
            a = firstSide;
            b = secondSide;
            c = thirdSide;
        }
        public int GetPerimetr()
        {
            return a + b + c;
        }

        public double GetAlpha()
        {
            return Math.Acos((double)(a * a - b * b - c * c) / (2 * b * c));
        }
        public double GetBeta()
        {
            return Math.Acos((double)(b * b - a * a - c * c) / (2 * a * c));
        }
        public double GetGamma()
        {
            return Math.Acos((double)(c * c - a * a - b * b) / (2 * a * b));
        }
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("One side of a triangle are less than or equal to 0");
                }
                if (value >= b + c)
                {
                    throw new ArgumentException("Triangle inequality is not fulfilled");
                }
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("One side of a triangle are less than or equal to 0");
                }
                if (value >= a + c)
                {
                    throw new ArgumentException("Triangle inequality is not fulfilled");
                }
                b = value;
            }
        }
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("One side of a triangle are less than or equal to 0");
                }
                if (value >= a + b)
                {
                    throw new ArgumentException("Triangle inequality is not fulfilled");
                }
                c = value;
            }
        }
        private int a;
        private int b;
        private int c;
    }

    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(int side): base(side, side, side)
        {
            sqare = side * side * Math.Sqrt(3) / 4;
        }
        public double GetSquare()
        {
            return sqare;
        }
        private double sqare;
    }
}
