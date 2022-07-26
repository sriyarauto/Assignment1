using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace displaynumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0;i< 4;i++)
            {
                Console.Write(a + " ");

            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write(a);

            }
            Console.WriteLine();
        }
    }
}
