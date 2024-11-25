using System;
namespace Array_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the size of an array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array Elements");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Display Array Elements");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();

        }
    }
}
