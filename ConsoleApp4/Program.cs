using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {

                Console.WriteLine("1.加法  2.减法  3.乘法  4.除法");
                Console.WriteLine("请输入要操作的数:");
                int m;
                m = Convert.ToInt32(Console.ReadLine());

                switch (m)
                {
                    case 1:
                        JiaFa n1 = new JiaFa();
                        n1.a = Convert.ToInt32(Console.ReadLine());
                        n1.b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("两个数相加结果为：{0}", n1.a + n1.b);
                        break;
                    case 2:
                        JianFa n2 = new JianFa();
                        n2.a = Convert.ToInt32(Console.ReadLine());
                        n2.b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("两个数相减结果为：{0}", n2.a - n2.b);
                        break;
                    case 3:
                        ChengFa n3 = new ChengFa();
                        n3.a = Convert.ToInt32(Console.ReadLine());
                        n3.b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("两个数相乘结果为：{0}", n3.a * n3.b);
                        break;
                    case 4:
                        ChuFa n4 = new ChuFa();
                        n4.a = Convert.ToInt32(Console.ReadLine());
                        n4.b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("两个数相除结果为：{0}", n4.a / n4.b);
                        break;
                        Console.ReadKey();
                }
            }
        }
            class JiaFa
        {
            public int a;
            public int b;

        }
        class JianFa

        {
            public int a;
            public int b;

        }
        class ChengFa
        {
            public int a;
            public int b;

        }
        class ChuFa
        {
            public int a;
            public int b;

        }



    }

 }
    




