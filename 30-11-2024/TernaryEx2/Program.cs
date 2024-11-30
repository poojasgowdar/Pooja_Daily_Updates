using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c = 40;
            int LargestNumber = 0;

            LargestNumber = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
            Console.WriteLine("Largest of two numbers is:" + LargestNumber);
            Console.ReadKey();
        }
    }
}
