using System;

namespace Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int boxedNumber = 10;
            int unboxedNumber = (int)boxedNumber; 
            Console.WriteLine("Boxed number: " + boxedNumber);
            Console.WriteLine("Unboxed number: " + unboxedNumber);
            Console.ReadKey();


        }
    }
}
