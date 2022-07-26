using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegOrPos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            if ((a > 0 && b < 0) || (a < 0 && b > 0))
                Console.WriteLine("true");
            else
                Console.WriteLine("False");
        }
    }
}
