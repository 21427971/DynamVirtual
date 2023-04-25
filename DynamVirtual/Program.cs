using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamVirtual
{
    class shape
    {// virtual funcion polymophism
        protected int height, width;string myname;
        public shape(int h=0,int w=0,string n="")
        {
            height = h;
            width = w;
            myname = n;
        }

        public virtual int Area()//parent class
        {
            return 0;
        }
        public virtual string PrintName()// parent class
        {
            return null;
        }
        class Rectangle :shape
        {
            public Rectangle(int h=0,int w=0,string n=""):base(h,w,n)
            {
                //KSI Msimango
            }
            public override int Area()
            {
                Console.WriteLine("Enter a height");
                height = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a width");
                width = int.Parse(Console.ReadLine());
                return (height*width);
            }
            public override string PrintName()
            {
                Console.WriteLine("Enter the shape name");
                myname = Convert.ToString(Console.ReadLine());
                return (myname);
            }
            class caller
            {
                static void Main(string[]args)
                {
                    Rectangle obj = new Rectangle();
                    double ar = obj.Area();
                    Console.WriteLine($"The area is :{ar}");
                    string nm = obj.PrintName();
                    Console.WriteLine($"The name of this shape is a {nm}");
                }
            }
        }
        
    }
}
