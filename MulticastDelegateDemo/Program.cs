using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegateDemo
{
    public delegate int SampleDelegate();
    public class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(MethodOne);
            del += MethodTwo;
            int ValueReturnedByDelegate = del();
            Console.WriteLine($"Returned Value = {ValueReturnedByDelegate}");
            Console.ReadKey();

        }
        public static int MethodOne()
        {
            Console.WriteLine("MethodOne is Executed");
            return 1;
        }
        public static int MethodTwo()
        {
            Console.WriteLine("MethodTwo is Executed");
            return 2;
        }

    }
}
