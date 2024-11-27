using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Using_abst
{
    public abstract class Person
    {
        public abstract void Work();

        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
   

    }

    public class Employee : Person
    {
        public override void Work()
        {
            Console.WriteLine("employee is working");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Work();
            

            //Person p = new Employee();
            //p.Work();
            //Console.WriteLine(p.age);
            Console.ReadKey();
        }
    }

      
}
