using System;
namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize a jagged Array
            int[][] jaggedArray = new int[3][];

            //Initialize sub-arrays with different sizes
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8};

            //Display the elements of the array
            Console.WriteLine("Jagged Array Elements");
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Row {i}: ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}


