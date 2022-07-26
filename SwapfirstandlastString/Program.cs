using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapfirstandlastString
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            s = Console.ReadLine();
            char[] m = s.ToCharArray();
            char f =m[0];
            char l = m[s.Length - 1];
            m[0] = l;
            m[s.Length - 1] = f;
            string str = new string(m);
            Console.WriteLine(str);



        }
    }
}
