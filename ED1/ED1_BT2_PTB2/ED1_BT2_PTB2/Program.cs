using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED1_BT2_PTB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double x1, x2, delta;

            Console.Write("\n Nhap vao so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so c: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Giai phuong trinh {0}x^2 + {1}x + {2} = 0.", a, b, c);

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("\n Vo so nghiem.");
                    }
                    else
                    {
                        Console.WriteLine("\n Vo nghiem.");
                    }
                }
                else
                {
                    x1 = (double)-c / b;
                    Console.WriteLine("\n Nghiem duy nhat x = {0}", Math.Round(x1, 2));
                }
            }
            else
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("\n Vo nghiem.");
                }
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    Console.WriteLine("\n Nghiem kep x1 = x2 = {0}", x1);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("\n Hai nghiem phan biet:\n X1 = {0}\n X2 = {1}", x1, x2);
                }
            }

            Console.ReadKey();
        }
    }
}
