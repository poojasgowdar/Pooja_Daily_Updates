using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MultithreadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread T1 = new Thread(Test.PrintNumbers);
            //The Start() method is used to begin the execution of a thread.
            T1.Start();
            Console.ReadKey();
        }
    }
    class Test
    {
        public static void PrintNumbers()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
