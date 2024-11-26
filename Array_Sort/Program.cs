using System;
namespace Array_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 7, 4, 9, 10, 12 };
            Array.Sort(arr);
            Console.WriteLine("Ascending Order:");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
