using System;
using System.Data;
namespace Multicast_Delegate_Ex
{
    internal class Program
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
    public delegate void dname(int a, int b);

    class Test
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            dname d1 = new dname(p.add);
            dname d2 = new dname(p.sub);
            dname d3 = d1 + d2;
            d3(5, 4);
            Console.ReadKey();

        }
    }

   
}
