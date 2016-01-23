using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(2.1,3.6);
            Circle circle = new Circle(2);
            Rhombus rhomb = new Rhombus(4.1,2.8);
            Circle circleSec = new Circle(4);
            List<BasicShape> shapes = new List<BasicShape>() { rect, circle, rhomb, circleSec };
            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0}\nArea: {1:F2}\nPerimeter: {2:F2}", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
                Console.WriteLine();
            }
        }
    }
}
