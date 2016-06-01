using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Rectangle
    {
        //private double length ;
        //private double width;

        //public Rectangle(double l , double w)
        //{

        //    length = l;
        //    width = w;
        //}
        //public double GetArea()
        //{
        //    return length * width;

        //}


        public event EventHandler Changed;
        private double width;
        private double length;
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0.0)
                    width = value;
            }
        }
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0.0)
                    length = value;
                Changed(this, EventArgs.Empty);
            }
        }

        public double GetArea()
        {
            return width * length;
        }

        public static string shapeName
        {
            get { return "Rectangle"; }
        }
    }
}
