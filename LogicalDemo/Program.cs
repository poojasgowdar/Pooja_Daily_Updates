using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = true, y = false, z;
            //Logical AND operator
            z = x && y;
            Console.WriteLine("Logical AND Operator (&&) : " + z);
            //Logical OR operator
            z = x || y;
            Console.WriteLine("Logical OR Operator (||) : " + z);
            //Logical NOT operator
            z = !x;
            Console.WriteLine("Logical NOT Operator (!) : " + z);
            Console.ReadKey();
        }
    }
}
