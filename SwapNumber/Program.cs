using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" a = "+a);
            Console.WriteLine(" b = " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(" After Swap");
            Console.WriteLine(" a = " + a);
            Console.WriteLine(" b = " + b);
        }
    }
}
