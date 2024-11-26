using System;
namespace Arr_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            foreach(int n in a)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
            

        }
    }
}
