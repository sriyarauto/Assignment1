using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your String");
            String s = Console.ReadLine();
            String[] sarr = s.Split(' ');
           int length= sarr[0].Length;
            string st = sarr[0];
            for(int i=1;i<sarr.Length;i++)
            {
                if (length < sarr[i].Length)
                {
                    length = sarr[i].Length;
                    st = sarr[i];
                }
            }
            Console.WriteLine(st);

        }
    }
}
