using System;
using System.Collections.Generic;

namespace TestWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> f = new List<Shape>();
            f.Add(new Triangle(3,2,4));
            f.Add(new Circle(5));
            foreach (var it in f) Console.WriteLine(it.Square());
        }
    }
}
