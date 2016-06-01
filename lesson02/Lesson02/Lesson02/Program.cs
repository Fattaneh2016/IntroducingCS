using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle myrect = new Rectangle(10.5, 20.6);

            //double area = myrect.GetArea();
            //Console.WriteLine("this is my rectangle area:{0}", area);

            //Rectangle myrec = new Rectangle();
            //myrec.Length = 10.5;
            //myrec.Width = 4.2;
            //double area = myrec.GetArea();
            //Console.WriteLine("this is my rectangle area  {0}", area);

            //Auto-implemented properties simplify property declarations 

            //public double Width { get; set; }
            //public double Length { get; set; }

            //Rectangle myrec = new Rectangle { Length = 20.5, Width = 5.9 };

            //Console.WriteLine("this is my area {0}" , myrec.GetArea());

            //}


            Rectangle r = new Rectangle();

            r.Changed += new EventHandler(r_Changed);
            r.Length = 10.2;
            Console.WriteLine("this is {0}" , Rectangle.shapeName );

        }
        static void r_Changed(object sender, EventArgs e)
    
            {
                Rectangle r = (Rectangle)sender;
                Console.WriteLine("Value Changed: Length = {0}", r.Length);
            }

    }


 }

