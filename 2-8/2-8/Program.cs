using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8
{
    class calculator
    {
        public int x, y, z;

        public void plus()
        {
            z = x + y;
        }
        public void minus()
        {
            z = x - y;
        }
        public void multiply()
        {
            z = x * y;
        }
        public void divide()
        {
            z = x / y;
        }
        public void Equals()
        {
            if (x == y)
            {
                Console.WriteLine("输入的两个数x，y相等");
            }
        }
    }
    class Stringcalculator
    {
        private String x;
        private String y;
        String str;

        public string X { get => x; set => x = value; }
        public string Y { get => y; set => y = value; }
        public void plus()
        {
            Console.WriteLine("计算结果为：" + (X + Y));
        }
        public void minus()
        {
            Console.WriteLine("");
            String str = X;
            str = str.Replace(Y, "");
            Console.WriteLine("运算结果为：" + str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.数字运算   2.字符串运算");
            int Choice = Convert.ToInt32(Console.ReadLine());
            if (Choice == 1)
            {
                try
                {
                    calculator C = new calculator();
                    Console.Write("请输入第一个数字x的值：");
                    C.x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("请输入要运行的运算符：");
                    String choice = Console.ReadLine();
                    Console.Write("请输入第二个数字y的值：");
                    C.y = Convert.ToInt32(Console.ReadLine());
                    C.Equals();
                    switch (choice)
                    {
                        case "+":
                            C.plus();
                            Console.WriteLine("加法运算的结果为：" + C.z);
                            break;
                        case "-":
                            C.minus();
                            Console.WriteLine("减法运算的结果为：" + C.z);
                            break;
                        case "*":
                            C.multiply();
                            Console.WriteLine("乘法运算的结果为：" + C.z);
                            break;
                        case "/":
                            C.divide();
                            Console.WriteLine("除法运算的结果为：" + C.z);
                            break;
                        default:
                            Console.WriteLine("输入的运算符有误！请重新输入！");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("操作出现错误！");
                }
            }
            else
            {
                Stringcalculator S = new Stringcalculator();
                Console.Write("请输入第一个字符串：");
                S.X = Convert.ToString(Console.ReadLine());
                Console.Write("请输入要运行的运算符：");
                String i = Console.ReadLine();
                Console.Write("请输入第二个字符串：");
                S.Y = Convert.ToString(Console.ReadLine());
                if (i == "+")
                {
                    S.plus();
                }
                else if (i == "-")
                {
                    S.minus();
                }
                else
                {
                    Console.WriteLine("输入错误！");
                }

            }
        }
    }
}
