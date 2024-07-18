using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED1_BT2_PTB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double x;

            Console.WriteLine("\n Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Giai phuong trinh {0}x + {1} = 0.", a, b);

            if (a == b)
            {
                if ( b == 0 )
                {
                    Console.WriteLine("Vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Vo nghiem");
                }
            }
            else
            {
                x = (double)-b/a;
                Console.WriteLine("Co nghiem la x = {0}", Math.Round(x,2));
            }

            Console.ReadKey();

        }
    }
}
