using System;
using System.Collections.Generic;
using System.Text;

namespace XAY_DUNG_LOP_QUADRATICEQUATION
{
    class QuadraticEquation
    {
        private double _a;
        private double _b;
        private double _c;

        public double A { get => _a; set => _a = value; }
        public double B { get => _b; set => _b = value; }
        public double C { get => _c; set => _c = value; }

        public QuadraticEquation(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public double GetDiscriminant()
        {
            return Math.Pow(B, 2) - 4 * A * C;
        }
        public double GetRoot1()
        {
            if (GetDiscriminant() < 0)
            {
                return 0;
            }
            else
            {
                double r1 = (-B + Math.Sqrt(GetDiscriminant())) / (2 * A);
                return r1;
            }
        }

        public double GetRoot2()
        {
            if (GetDiscriminant() < 0)
            {
                return 0;
            }
            else
            {
                double r2 = (-B - Math.Sqrt(GetDiscriminant())) / (2 * A);
                return r2;
            }
        }
    }
}
