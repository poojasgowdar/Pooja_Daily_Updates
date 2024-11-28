using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Qn_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            fun(ref arr);
            for (int i = 0; i < arr.Length; i++)
            Console.WriteLine(arr[i] + " ");
            Console.ReadKey();
        }
        static void fun(ref int[] a)
        {
            a = new int[6];
            a[3] = 32;
            a[1] = 24;
        }
    }
}


