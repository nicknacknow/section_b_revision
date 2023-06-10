
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018
{
    internal class Program
    {
        static bool is_prime(int n)
        {
            List<int> factors = new List<int>();

            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    factors.Add(i);

            return factors.Count == 1;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n <= 1)
                    Console.WriteLine("Not greater than 1");
                else
                {
                    if (is_prime(n))
                    {
                        Console.WriteLine("Is prime");
                    }
                    else
                    {
                        Console.WriteLine("Is not prime");
                    }
                }

                Console.WriteLine("wanna input another number [y/n]");
                if (Console.ReadLine() == "n") break;
            }
        }
    }
}
