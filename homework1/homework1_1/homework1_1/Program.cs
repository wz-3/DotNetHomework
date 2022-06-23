using System;

namespace homework1_1
{
    class Program
    {
       static void Main(string[] args)
            {
                double a, b;
                char opertate;

                Console.WriteLine("请输入第一个运算数：");
                string str1 = Console.ReadLine();
                a = Convert.ToDouble(str1);

                Console.WriteLine("请输入运算符号：");
                string str2 = Console.ReadLine();
                opertate = Convert.ToChar(str2);

                Console.WriteLine("请输入第二个运算数：");
                string str3 = Console.ReadLine();
                b = Convert.ToDouble(str3);

                switch (opertate)
                {
                    case '+':
                        Console.WriteLine($"{a} + {b}={a + b}");
                        break;
                    case '-':
                        Console.WriteLine($"{a} - {b}={a - b}");
                        break;
                    case '*':
                        Console.WriteLine($"{a} * {b}={a * b}");
                        break;
                    case '/':
                        Console.WriteLine($"{a} / {b}={a / b}");
                        break;
                    case '%':
                        Console.WriteLine($"{a} % {b}={a % b}");
                        break;
                    default:
                        Console.WriteLine("运算符不正确"); break;
                }
            }
     
    }
}
