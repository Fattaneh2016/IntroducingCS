using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
   abstract  class Polygon
    {
        public double Length { get; protected set; }
        public double Width { get;protected set; }
        abstract public double getArea1();
    }

    class Rectangle1:Polygon
    {
        public Rectangle1(double length ,double width)
        {
            Length = length;
            Width = Width;

        }

        public override double getArea1()
        {
            return Width * Length;
        }
    }
}
