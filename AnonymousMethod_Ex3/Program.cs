using System;


namespace AnonymousMethod_Ex3
{
    internal class Program
    {

        public delegate string Greet(string message);
        static void Main(string[] args)
        {
            Greet g = delegate (string message)
            {
                return "Hi" + message;
            };
            g("pooja");
            Console.ReadKey();

        }
    }
}
