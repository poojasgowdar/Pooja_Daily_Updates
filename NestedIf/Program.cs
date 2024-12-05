using System;
using System.Diagnostics.Eventing.Reader;
namespace NestedIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 200, c = 30;
            if (a > b)
            {
                Console.WriteLine("Outer If Block");
                if (a > c)
                {
                    Console.WriteLine("A is greater");
                }
                else
                {
                    Console.WriteLine("C is greater");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("B is greater");
                }
                else
                {
                    Console.WriteLine("C is greater");
                }
            }
            Console.ReadKey();
        }
    }
}
