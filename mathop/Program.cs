using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Sum is = "+(a+b));
            Console.WriteLine(" Subtraction = "+(a- b));
            Console.WriteLine(" Multiplication = " + (a * b));
            Console.WriteLine(" Division = " + (a/b));
        }
    }
}
