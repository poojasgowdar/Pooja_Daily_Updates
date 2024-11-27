using System;


namespace Ternary_Operator_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 50;
            int q = 40;
            int max = p > q ? p : q;
            Console.WriteLine("Maximum of " + p + " & " + q + " is " + max);
            Console.ReadKey();
        }


    }
}
