using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    abstract class Shape
    {
        public Shape(List<int> sides)
        {
            foreach(int side in sides)
            {
                if (side <= 0)
                {
                    throw new ArgumentException("Side must be greater then 0");
                }
            }
        }
        abstract public double GetPerimetеr();
        abstract public double GetArea();
    }
    class Triangle : Shape
    {
        public Triangle(int firstSide, int secondSide, int thirdSide): 
            base(new List<int>() { firstSide, secondSide, thirdSide })
        {
            if (firstSide >= secondSide + thirdSide || secondSide >= firstSide + thirdSide ||
                thirdSide >= firstSide + secondSide)
            {
                throw new ArgumentException("Triangle inequality is not fulfilled");
            }
            a = firstSide;
            b = secondSide;
            c = thirdSide;
        }
        public override double GetPerimetеr()
        {
            return a + b + c;
        }
        public override double GetArea()
        {
            double p = (double)(a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        private int a;
        private int b;
        private int c;
    }

    class Circle : Shape
    {
        public Circle(int initialRadius): base(new List<int>() { initialRadius })
        {
            radius = initialRadius;
        }

        public override double GetPerimetеr()
        {
            return 2 * Math.PI * radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        private int radius; 
    }

    class Square: Shape
    {
        public Square(int initialSide): base(new List<int>() { initialSide })
        {
            side = initialSide;
        }

        public override double GetPerimetеr()
        {
            return 4 * side;
        }
        public override double GetArea()
        {
            return side * side;
        }
        private int side; 
    }

    class Rectangle : Shape
    {
        public Rectangle(int firstSide, int secondSide) : base(new List<int>() { firstSide, secondSide })
        {
            x = firstSide;
            y = secondSide;
        }

        public override double GetPerimetеr()
        {
            return 2 * (x + y);
        }
        public override double GetArea()
        {
            return x * y;
        }
        private int x;
        private int y;
    }

    class Rhombus : Shape
    {
        public Rhombus(int initialD1, int initialD2) : base(new List<int>() { initialD1, initialD2 })
        {
            d1 = initialD1;
            d2 = initialD2;
        }

        public override double GetPerimetеr()
        {
            return 2 * Math.Sqrt((double)d1 * d1  + (double)d2 * d2);
        }
        public override double GetArea()
        {
            return (double)d1 * d2 / 2.0;
        }
        private int d1;
        private int d2;
    }
}
