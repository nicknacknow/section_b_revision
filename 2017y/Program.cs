using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017y
{
    internal class Program
    {
       static string function_name(string inp)
        {
            string ret = "";
            char last = inp[0];
            int num = 0;

            foreach (char c in inp)
            {
                if (c == last)
                    num++;
                else
                {
                    ret += $"{last} {num} ";
                    last = c;
                    num = 1;
                }
            }
            ret += $"{last} {num} ";

            return ret;
        }
        static void Main(string[] args)
        {
            while (true)
            {
               string isitreallythiseasy = Console.ReadLine();
                Console.WriteLine(function_name(isitreallythiseasy));
            }
        }
    }
}
