using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    using Interfaces;
    class Circle : BasicShape,IShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius cannot be negative");
                }
                this.radius = value;
            }
        }

        public override double CalculateArea()
        {
            return Math.PI * (this.Radius * this.Radius);
        }
        public override double CalculatePerimeter()
        {
            return (2 * Math.PI) * this.Radius;
        }
    }
}
