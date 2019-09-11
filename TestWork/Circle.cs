using System;
using System.Collections.Generic;
using System.Text;

namespace TestWork
{
    class Circle: Shape
    {
        double R { get; set; }
        public Circle(double R) => this.R = R;

        public override double Square() => Math.PI * Math.Pow(R, 2);
    }
}
