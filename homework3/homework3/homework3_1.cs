using System;

namespace Shape
{
    public abstract class ShapeClass
    {
        public abstract double Area();
        public abstract bool IsValid();
    }
    class Rectangle : ShapeClass
    {
        public double length { get; set; }
        public double width { get; set; }
        public Rectangle(double length0,double width0)
        {
            length = length0;
            width = width0;
        }
        public override double Area()
        {
            if (!IsValid())
                throw new Exception("形状非法，长方形边长应大于0 ");
            else
                return length * width;
        }
        public override bool IsValid()
        {
            if (length <= 0 || width <= 0)
                return false;
            return true;
        }
    }
    class Square : ShapeClass
    {
        public double side { get; set; }
        public Square(double side0)
        {
            side = side0;
        }
        public override double Area()
        {
            if (!IsValid())
                throw new Exception("形状非法，正方形边长应大于0 ");
            else
                return side * side;
        }
        public override bool IsValid()
        {
            if (side <= 0)
                return false;
            return true;
        }
    }
    class Triangle : ShapeClass
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }
        public Triangle(double Side1,double Side2,double Side3)
        {
            side1 = Side1;
            side2 = Side2;
            side3 = Side3;
        }
        public override double Area()
        {
            if (!IsValid())
                throw new Exception("形状非法，三角形三边长均应大于0且两边之和大于第三边 ");
            else
                return Math.Sqrt((side1 + side2 + side3) * (side1 + side2 - side3) * (side1 + side3 - side2) * (side2 + side3 - side1) / 16);
        }
        public override bool IsValid()
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0 || side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                return false;
            return true;
        }
    }
    
  class homework3
    {

        static void Main(string[] args)
        {
            try
            {
                Rectangle exm1 = new Rectangle(3.5,6.0);
                Console.WriteLine("长方形面积为：" + exm1.Area());

                Square exm2 = new Square(3.6);
                Console.WriteLine("正方形面积为：" + exm2.Area());

                Triangle exm3 = new Triangle(5.0,12.0,13.0);
                Console.WriteLine("三角形面积为：" + exm3.Area());

                Triangle exm4 = new Triangle(3.5,6.0,2.5);
                Console.WriteLine("三角形面积为：" + exm4.Area());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}
