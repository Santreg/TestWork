using System;
using System.Collections.Generic;
using System.Text;

namespace TestWork
{
    class Triangle:Shape
    {
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }
        public Triangle(double A, double B, double C) { this.A = A;this.B = B;this.C = C; }

        double P { get { return (A + B + C) / 2; } }
        public bool IsRected
        {
            get
            {
                return (Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2)) || 
                    (Math.Pow(A, 2) == Math.Pow(C, 2) + Math.Pow(B, 2)) || 
                    (Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2));
            }
        }
        public override double Square() => Math.Sqrt(P * (P - A) * (P - B) * (P - C));

    }
}
