using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    using Interfaces;
    abstract class BasicShape : IShape
    {
        private double height;
        private double width;

        public double Height
        {
            get { return this.height; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be negative");
                }
                this.height = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be negative");
                }
                this.width = value;
            }
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
