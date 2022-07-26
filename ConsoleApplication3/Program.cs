using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of batches");
            int batchs = Convert.ToInt32(Console.ReadLine());
            int s_count;
            int[][] school = new int[batchs][];
            for(int i=0;i<batchs;i++)
            {
                Console.WriteLine("Enter no. of student in Batch " + (i + 1));
                s_count = Convert.ToInt32(Console.ReadLine());
                school[i] = new int[s_count];
            }
            for(int i=0;i<batchs;i++)
            {
                Console.WriteLine("Enter the marks for all students in Batch " + (i + 1));
                for(int j=0;j<school[i].Length;j++)
                {
                    school[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i=0;i<batchs;i++)
            {
                int sum = 0;
                Console.WriteLine("Batch......................." + i+1);
                for(int j=0;j<school[i].Length;j++)
                {
                    sum += school[i][j];
                }
                Console.WriteLine("Average id = " + sum / school[i].Length);
                Console.WriteLine("Sum is = " + sum);
            }
        }
    }
}
