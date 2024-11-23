using System;
namespace Class_Object_Ex
{
    internal class Program
    {
        public int age = 20;
        public string name = "pooja";

        public void marks()
        {
            Console.WriteLine("Good Marks");
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.age);
            Console.WriteLine(p.name);
            p.marks();
            Console.ReadKey();
        }
    }
}
