using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Using_abst1
{
     abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("This animal is sleeping");
        }

        public void Eat()
        {
            Console.WriteLine("This animal is eating");
        }
    }

     class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

     class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cow meows");
        }
    }

     class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.MakeSound();
            d.Sleep();
            d.Eat();

            Cat c = new Cat();
            c.MakeSound();
            c.Sleep();
            c.Eat();
            Console.ReadKey();

        }
    }
}
