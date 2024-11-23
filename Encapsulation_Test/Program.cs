using System;
namespace Encapsulation_Test
{
    internal class Program
    {
        private int age;

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            if (age > 0)
            {
                Console.WriteLine("Valid Age");
                this.age = age;
                
            }
            else
            {
                Console.WriteLine("Not a Valid Age");
            }
           
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.setAge(20);
            Console.WriteLine(p.getAge());
            Console.ReadKey();
        }
    }
}
