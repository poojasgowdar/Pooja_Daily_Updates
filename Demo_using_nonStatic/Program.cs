using System;
namespace Demo_using_nonStatic
{
    internal class Program
    {
        public delegate int delegatedemo(int a, int b);

        static int Add(int a,int b)
        {
            return a + b;
        }

        static int Sub(int a,int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            delegatedemo d1 = Add;
            Console.WriteLine($"Addition : {d1(5, 3)}");
            delegatedemo d2 = Sub;
            Console.WriteLine($"Subtraction : {d2(5, 4)}");
            Console.ReadKey();
        }
    }
}
