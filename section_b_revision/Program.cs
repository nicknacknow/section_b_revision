using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section_b_revision
{
    class Program
    {
        static bool is_harshad(int n)
        {
            int sum = 0;
            foreach (char c in n.ToString())
                sum += int.Parse(c.ToString());

            return n % sum == 0;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int inp = int.Parse(Console.ReadLine());
                Console.WriteLine(is_harshad(inp));
            }
        }
    }
}