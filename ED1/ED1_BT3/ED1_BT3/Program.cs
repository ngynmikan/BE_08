using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED1_BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input C degree: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kevin degree = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit degree = {0}", celsius * 18 / 10 +32);
            Console.ReadKey();
        }
    }
}
