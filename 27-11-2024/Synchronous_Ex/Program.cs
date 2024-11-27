using System;
using System.Threading;

namespace Synchronous_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LongTerm();
            ShortTerm();
            Console.ReadKey();
        }

        static void LongTerm()
        {
            Console.WriteLine("LongTerm Process started");
            Thread.Sleep(4000);
            Console.WriteLine("LongTerm Process ended");
        }

        static void ShortTerm()
        {
            Console.WriteLine("ShortTerm Process started");
            Thread.Sleep(5000);
            Console.WriteLine("shortTerm Process ended");
        }
    }
}
