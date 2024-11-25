using System;
namespace AnonymousMethod_Ex2
{
    internal class Program
    {

        public delegate void add(int a, int b);
        static void Main(string[] args)
        {
            add d = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };
            d(5, 5);
            Console.ReadKey();
        }
    }
}
