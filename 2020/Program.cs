using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                Console.WriteLine("how many digits will you input ? ");
                int n = int.Parse(Console.ReadLine());
                
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"input {i + 1}: ");
                    int inp = int.Parse(Console.ReadLine());

                    if (dict.ContainsKey(inp)) dict[inp]++;
                    else dict.Add(inp, 1);
                }

                int highest = int.MinValue;
                int key = -1;

                foreach (KeyValuePair<int, int> pair in dict)
                    if (pair.Value > highest) { highest = pair.Value; key = pair.Key; }

                // check for multimodal

                int num_with_highest = 0;

                foreach (KeyValuePair<int, int> pair in dict)
                    if (pair.Value == highest) num_with_highest++;

                if (num_with_highest > 1)
                {
                    Console.WriteLine("Data was multimodal");
                }
                else
                {
                    Console.WriteLine($"{key} was repeated {dict[key]} times");
                }
            }
        }
    }
}
