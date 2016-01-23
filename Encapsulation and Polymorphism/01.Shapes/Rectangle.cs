using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    using Interfaces;
     class Rectangle : BasicShape
    {
        public Rectangle(double height,double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (this.Height + this.Width);
        }
    }
}
