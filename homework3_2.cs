using System;
using System.Collections.Generic;
using System.Text;
using Shape;

namespace homework3
{
    public class factoryShape
    {
        public static ShapeClass CreateShape(string type, params double[] side)
        {
            ShapeClass shape;
            switch (type)
            {
                case "rectangle":
                    shape = new Rectangle(side[0], side[1]);
                    return shape;
                case "square":
                    shape = new Square(side[0]);
                    return shape;
                case "triangle":
                    shape = new Triangle(side[0], side[1], side[2]);
                    return shape;
                default: throw new InvalidOperationException("The Shape doesn't exist");
            }
        }
    }
    //运行时将另一文件中main方法类注释掉
    class Try
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] type = { "rectangle", "square", "triangle" };
                ShapeClass[] TenShape = new ShapeClass[10];
                double AreaSum = 0;
                Random rd = new Random();
                //创建10个形状对象
                for (int shapeNum = 0; shapeNum < 10; shapeNum++)
                {
                    ShapeClass exmp = factoryShape.CreateShape(type[rd.Next(3)],10* rd.NextDouble(),10* rd.NextDouble(),10* rd.NextDouble());
                    if (exmp.IsValid())
                        TenShape[shapeNum] = exmp; 
                }
                //计算面积之和
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("第" + (i + 1) + "个图形:"+TenShape[i].GetType().Name.ToString()+"  面积："+TenShape[i].Area());
                    AreaSum = AreaSum + TenShape[i].Area();
                }
                Console.WriteLine("10个形状对象的总面积是：" + AreaSum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}




