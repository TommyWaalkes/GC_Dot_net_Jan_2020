using System;

namespace ShapesObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10);
            double area = c.GetArea();

            Console.WriteLine(area);
        }
    }
}
