using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleSwitchs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "C#";
            switch (str)
            {
                case "C#":
                case "Java":
                case "C++":
                    Console.WriteLine("All three PL");
                    break;

                case "SQL":
                case "mysql":
                case "PL/SQL":
                    Console.WriteLine("All three are backend language");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
