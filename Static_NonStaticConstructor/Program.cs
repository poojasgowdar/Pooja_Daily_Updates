using System;
namespace Static_NonStaticConstructor
{
    class Geeks
    {
        static int s;
        int y;

        static Geeks()
        {
            Console.WriteLine("Executed");
        }
        public Geeks(int x)
        {
            y = x;
        }

        static void Main(string[] args)
        {
            Geeks g = new Geeks(10);
            Console.WriteLine(g.y);
            Console.ReadKey();
        }
    }
}
