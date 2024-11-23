using System;

namespace Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int boxedNumber = 10;
            object bx = boxedNumber;
            int ubx = (int)bx;


            int unboxedNumber = (int)boxedNumber;
            Console.WriteLine(boxedNumber);
            Console.WriteLine(ubx);
            Console.WriteLine("Boxed number: " + boxedNumber);
            Console.WriteLine("Unboxed number: " + unboxedNumber);
            Console.ReadKey();


        }
    }
}
