using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Rows and Columns of an Array");
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] Matrix1 = new int[rows, cols];
            int[,] Matrix2 = new int[rows, cols];
            int[,] res = new int[rows, cols];

            Console.WriteLine("Enter the elements of first matrix");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Matrix1[i, j] = int.Parse(Console.ReadLine());
                }
               
            }
            Console.WriteLine("Enter the elements of second matrix");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Sum of two matrices");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    res[i, j] = Matrix1[i, j] + Matrix1[i, j];
                    Console.WriteLine(res[i, j]);
                }
            }

           
            Console.ReadKey();

        }
    }
}
