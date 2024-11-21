using System;
namespace AnonymousMethod_Ex
{
    internal class Program
    {

        public delegate void Result(string message);

        static void Main(string[] args)
        {
            Result s = delegate (string message)
            {
                Console.WriteLine("Good Morning " +message);
            };
            s("John");
            Console.ReadKey();
        }
    }
}
