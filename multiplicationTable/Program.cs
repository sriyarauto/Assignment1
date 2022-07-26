using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
             for(int i=1;i<=10;i++)
            {
                Console.WriteLine(a + " * " + i + " = " + (a * i));
            }
        }
    }
}
