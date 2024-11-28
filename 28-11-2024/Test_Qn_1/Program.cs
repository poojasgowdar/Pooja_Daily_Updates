using System;


namespace Test_Qn_1
{
    public class Csharp
    {
        public void subject<S>(S arg)
        {
            Console.WriteLine(arg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Csharp c = new Csharp();
            c.subject("hi");
            c.subject(20);
            Console.ReadKey();
        }
    }
}
