using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED1_BT1
{
    internal class Program
    {

        static void Sum(int a, int b)
        {
            Console.WriteLine(" Sum {0} and {1} : {2}", a, b, a + b);
        }

        static void Min(int a, int b)
        {
            Console.WriteLine(" Min {0} and {1} : {2}", a, b, a - b);
        }

        static void Product(int a, int b)
        {
            Console.WriteLine(" Product {0} and {1} : {2}", a, b, a * b);
        }

        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Input number 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number 2: ");
            b = Convert.ToInt32(Console.ReadLine());

            Sum(a, b);
            Min(a, b);
            Product(a, b);

            Console.ReadKey();
        }
    }
}
