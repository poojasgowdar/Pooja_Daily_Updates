using System;


namespace Constructor_Ex
{
    internal class Program
    {
        int age;
        string name;
        public Program(int sage,string sname)
        {
            age = sage;
            name = sname;

        }
        static void Main(string[] args)
        {
            Program p = new Program(10,"pooja");
            Console.WriteLine("Age:" +p.age);
            Console.WriteLine("Name:" +p.name);
            Console.ReadKey();
        }
    }
}
