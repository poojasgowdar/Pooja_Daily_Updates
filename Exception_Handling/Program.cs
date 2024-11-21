using System;
using System.Collections.Generic;


namespace Exception_Handling
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //int[] a = { 1, 2, 3, 4, 5 };
            //try
            //{
            //    Console.WriteLine(a[6]);
            //}
            //catch(IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //int a = 10, b = 0;
            //try
            //{
            //    Console.WriteLine(a/b);
            //}
            //catch(ArithmeticException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //try
            //{
            //    int x = int.Parse("abd");
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            try
            {
                string s = null;
                Console.WriteLine(s);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
