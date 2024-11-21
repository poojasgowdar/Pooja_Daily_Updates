using System;
namespace AnonymousMethod_Ex1
{
    internal class Program
    {

        public delegate int dname(int a, int b);
        static void Main(string[] args)
        {
            dname d = delegate (int a, int b)
            {
                //Console.WriteLine(a + b);
                return a + b;
            };
            dname d1 = delegate (int a, int b)
            {
                //Console.WriteLine(a - b);
                return a - b;
            };
            //d(4, 5);
            //d1(4, 5);
            Console.WriteLine("Addition :" + d(4, 5));
            Console.WriteLine("Subtraction:" + d1(5, 5));
            Console.ReadKey();
        }
    }
}
