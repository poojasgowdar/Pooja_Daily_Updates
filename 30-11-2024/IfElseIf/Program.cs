using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is a Even Number");
            }
            else
            {
                Console.WriteLine($"{num} is not a Even Number");
            }
            Console.ReadKey();
        }
    }
}
