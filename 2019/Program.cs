using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019
{
    class Program
    {
        static bool function_name(string s1, string s2)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in s2) // load dictionary
                if (map.ContainsKey(c))
                    map[c]++;
                else map.Add(c, 1);

            foreach (char c2 in s1)
            {
                if (!map.ContainsKey(c2)) return false;
                if (map[c2] == 0) return false;
                map[c2]--;
            }

            return true;
        }
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("first word:");
                string inp1 = Console.ReadLine();
                Console.WriteLine("second word:");
                string inp2 = Console.ReadLine();


                Console.WriteLine(function_name(inp1, inp2));
            }
        }
    }
}
