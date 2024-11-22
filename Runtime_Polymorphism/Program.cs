using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism
{
    //Inheritance
    //Method Overriding
    //Upcasting
       class Employee
        {
            public virtual void Work()
            {
                Console.WriteLine("Employee is Working");
            }
        }

        class Developer : Employee
        {
            public override void Work()
            {
                Console.WriteLine("Developer is developing Code");
            }
        }

        class Tester : Employee
        {
            public override void Work()
            {
                Console.WriteLine("Tester is testing the Code");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Developer();
                emp.Work();

                Employee emp2 = new Tester();
                emp2.Work();
                Console.ReadKey();
            }
        }
    }


