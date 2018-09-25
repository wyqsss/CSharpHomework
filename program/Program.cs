using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public interface shapes
    {
        double Area
        {
            get;
        }
        void display();
    }
   public class Triangle:shapes
    {
       private double mya, myb, myc;
      public Triangle(int a,int b,int c)
        {
            mya = a;
            myb = b;
            myc = c;

        }

        public double Area
        {
            get
            {
                return System.Math.Sqrt(((mya + myb + myc) / 2) * (myb / 2 + myc / 2 - mya / 2) * (mya / 2 + myc / 2 - myb / 2) * (mya / 2 + myb / 2 - myc / 2));
                //throw new NotImplementedException();
            }
        }

        public void display()
        {
            Console.WriteLine("三角形面积：" + Area);
            //throw new NotImplementedException();
        }
    }

    
   public class Square : shapes
    {
        private double mySide;
        public Square(double side)
        {
            mySide = side;
        }
        public double Area
        {
            get
            {
                return mySide * mySide;
                //throw new NotImplementedException();
            }
        }

        public void display()
        {
            Console.WriteLine("正方形面积：" + Area);
            //throw new NotImplementedException();
        }
    }

    public class Circle : shapes
    {
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public double Area
        {
            get
            {
                return 3.14 * r * r;
                //throw new NotImplementedException();
            }
        }

        public void display()
        {
            Console.WriteLine("圆形面积："+Area);
            //throw new NotImplementedException();
        }
    }

    public class Rectangle : shapes
    {
        private double mywidth, myheight;
        public Rectangle(double width,double height)
        {
            mywidth = width;
            myheight = height;
        }

        public double Area
        {
            get
            {
                return myheight * mywidth;
                //throw new NotImplementedException();
            }
        }

        public void display()
        {
            Console.WriteLine("长方形面积：" + Area);
            //throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle s_1 = new Triangle(3, 4, 5);
            Square s_2 = new Square(5);
            Circle s_3 = new Circle(2.5);
            Rectangle s_4 = new Rectangle(12, 23);
            s_1.display();
            s_2.display();
            s_3.display();
            s_4.display();
        }
    }
}
