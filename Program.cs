using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, n, p = 0;
            string str = "8-1+100-99+345-777+45";
            string[] s = str.Split('+', '-');
            n = s.Length;

            for (i = 0; i < n; i++)
            {
                if (Convert.ToInt32(i) % 2 == 0)
                    p += Convert.ToInt32(s[i]);
                else
                    p -= Convert.ToInt32(s[i]);
            }
            Console.WriteLine(str + " = " + p);
            Console.ReadKey();
        }
    }
}