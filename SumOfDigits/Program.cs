using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigitOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int n = Convert.ToInt32(Console.ReadLine());
            int r, sum = 0;
            while (n > 0)
            {
                r = n % 10;
                sum += r;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
