using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016
{
    internal class Program
    {
        static int div(int a, int b)
        {
            return (a - (a % b)) / b;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter integer (0-99)");
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine("Calcualte additive or multiplicative persistence (a or m)");
                string operation = Console.ReadLine();

                int count = 0;

                while (value > 9)
                {
                    if (operation == "a")
                        value = div(value, 10) + (value % 10);
                    else
                        value = div(value, 10) * (value % 10);

                    count++;
                }

                Console.WriteLine($"The persistence is: {count}");
            }
        }
    }
}

// this one is difficult cuz of div thing .. . .